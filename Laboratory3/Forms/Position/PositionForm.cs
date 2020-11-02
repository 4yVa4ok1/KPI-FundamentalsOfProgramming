using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Laboratory3.Database1DataSet;

namespace Laboratory3.Forms.Position
{
	public partial class PositionForm : Main
	{
		PositionRow row;

		public PositionForm()
		{
			InitializeComponent();

			BindEvents();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (this.Tag != null)
			{
				var position = this.database1DataSet.Position.FindById((int)this.Tag);
				if (position != null)
				{
					this.row = position;

					this.txbxName.Text = position.Name;
				}
			}
		}

		private void BindEvents()
		{
			this.btnSave.Click += BtnSave_Click;
			this.btnCancel.Click += BtnCancel_Click;

			this.txbxName.Validating += Txbx_Validating;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateControls())
			{
				return;
			}

			var name = this.txbxName.Text;
			if (this.row == null)
			{
				var id = this.database1DataSet.Position.AsEnumerable().Max(r => r.Id) + 1;
				this.positionTableAdapter.Insert(id, name);
			}
			else
			{
				this.row.Name = name;

				this.positionTableAdapter.Update(this.row);
			}

			var form = new PositionFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			var form = new PositionFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void Txbx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var textBox = (TextBox)sender;
			if (!this.ValidateEmptyTextBox(textBox))
			{
				e.Cancel = true;
			}
		}

		private void PositionForm_Load(object sender, EventArgs e)
		{
			this.positionTableAdapter.Fill(this.database1DataSet.Position);
		}
	}
}
