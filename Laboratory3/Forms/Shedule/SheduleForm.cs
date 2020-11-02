using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Laboratory3.Database1DataSet;

namespace Laboratory3.Forms.Shedule
{
	public partial class SheduleForm : Main
	{
		SheduleRow row;

		public SheduleForm()
		{
			InitializeComponent();

			BindEvents();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (this.Tag != null)
			{
				var shedule = this.database1DataSet.Shedule.FindById((int)this.Tag);
				if (shedule != null)
				{
					this.row = shedule;

					this.txbxName.Text = shedule.Name;
					this.txbxDescription.Text = shedule.Description;
				}
			}
		}

		protected override bool ValidateControls()
		{
			return this.ValidateEmptyTextBox(this.txbxName);
		}

		private void BindEvents()
		{
			this.btnSave.Click += BtnSave_Click;
			this.btnCancel.Click += BtnCancel_Click;

			this.txbxName.Validating += Txbx_Validating;
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

			var name = this.txbxName.Text;
			var description = this.txbxDescription.Text;
			if (this.row == null)
			{
				var id = this.database1DataSet.Shedule.AsEnumerable().Max(r => r.Id) + 1;
				this.sheduleTableAdapter.Insert(id, name, description);
			}
			else
			{
				this.row.Name = name;
				this.row.Description = description;

				this.sheduleTableAdapter.Update(this.row);
			}

			var form = new SheduleFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			var form = new SheduleFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void SheduleForm_Load(object sender, EventArgs e)
		{
			this.sheduleTableAdapter.Fill(this.database1DataSet.Shedule);

		}
	}
}
