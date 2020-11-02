using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Laboratory3.Database1DataSet;

namespace Laboratory3.Forms.Employee
{
	public partial class EmployeeForm : Main
	{
		EmployeeRow row;

		public EmployeeForm()
		{
			InitializeComponent();

			BindEvents();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			BindData();

			if (this.Tag != null)
			{
				var employee = this.database1DataSet.Employee.FindById((int)this.Tag);
				if(employee != null)
				{
					this.row = employee;

					this.txbxFirstName.Text = employee.FirstName;
					this.txbxSecondName.Text = employee.SecondName;
					this.txbxLastName.Text = employee.LastName;
					this.upDownAge.Value = employee.Age;
					if(!employee.IsPositionIdNull()) this.cmbxPosition.SelectedValue = employee.PositionId;
					if(!employee.IsSheduleIdNull()) this.cmbxShedule.SelectedValue = employee.SheduleId;
				}
			}
		}

		private void BindData()
		{
			//Привязка данных к выпадающим спискам и добавление возможности выбрать null
			var positionSouce = this.database1DataSet.Position.Select(r => new KeyValuePair<int, string>(r.Id, r.Name)).ToList();
			var sheduleSource = this.database1DataSet.Shedule.Select(r => new KeyValuePair<int, string>(r.Id, r.Name)).ToList();
			positionSouce.Add(new KeyValuePair<int, string>(default, "--Null--"));
			sheduleSource.Add(new KeyValuePair<int, string>(default, "--Null--"));

			this.cmbxPosition.DataSource = new BindingSource(positionSouce.OrderBy(r => r.Key), null);
			this.cmbxShedule.DataSource = new BindingSource(sheduleSource.OrderBy(r => r.Key), null);

			this.cmbxPosition.ValueMember = this.cmbxShedule.ValueMember = "Key";
			this.cmbxPosition.DisplayMember = this.cmbxShedule.DisplayMember = "Value";
		}

		private void BindEvents()
		{
			this.btnSave.Click += BtnSave_Click;
			this.btnCancel.Click += BtnCancel_Click;

			this.txbxFirstName.Validating += Txbx_Validating;
			this.txbxLastName.Validating += Txbx_Validating;
			this.txbxSecondName.Validating += Txbx_Validating;
		}

		private void Txbx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var textBox = (TextBox)sender;
			if (!this.ValidateEmptyTextBox(textBox))
			{
				e.Cancel = true;
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateControls())
			{
				return;
			}

			var firstName = this.txbxFirstName.Text;
			var secondName = this.txbxSecondName.Text;
			var lastName = this.txbxLastName.Text;
			var age = (int)this.upDownAge.Value;
			var position = (int)this.cmbxPosition.SelectedValue == default ? (int?)null : (int)this.cmbxPosition.SelectedValue;
			var shedule = (int)this.cmbxShedule.SelectedValue == default ? (int?)null : (int)this.cmbxShedule.SelectedValue;
			if (this.row == null)
			{
				var id = this.database1DataSet.Employee.AsEnumerable().Max(r => r.Id) + 1;
				this.employeeTableAdapter.Insert(id, firstName, lastName, secondName, age, position, shedule);
			}
			else
			{
				this.row.FirstName = firstName;
				this.row.SecondName = secondName;
				this.row.LastName = lastName;
				this.row.Age = age;

				if (position.HasValue) 
				{
					this.row.PositionId = position.Value;
				}
				else
				{
					this.row.SetPositionIdNull();
				}

				if (shedule.HasValue)
				{
					this.row.SheduleId = shedule.Value;
				}
				else
				{
					this.row.SetSheduleIdNull();
				}

				this.employeeTableAdapter.Update(this.row);
			}

			var form = new EmployeeFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			var form = new EmployeeFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void EmployeeForm_Load(object sender, EventArgs e)
		{
			this.sheduleTableAdapter.Fill(this.database1DataSet.Shedule);
			this.positionTableAdapter.Fill(this.database1DataSet.Position);
			this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

		}
	}
}
