namespace Laboratory3.Forms.Employee
{
	public partial class EmployeeFrame : Main
	{
		public EmployeeFrame()
		{
			InitializeComponent();

			BindEvents();
		}

		private void BindEvents()
		{
			this.btnAdd.Click += BtnAdd_Click;
			this.btnEdit.Click += BtnEdit_Click;
			this.employeeDataGridView.UserDeletedRow += EmployeeDataGridView_UserDeletedRow;
		}

		private void BtnAdd_Click(object sender, System.EventArgs e)
		{
			var form = new EmployeeForm
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void BtnEdit_Click(object sender, System.EventArgs e)
		{
			var id = (int)this.employeeDataGridView.CurrentRow.Cells["IdColumn"].Value;
			var form = new EmployeeForm
			{
				Location = this.Location,
				Tag = id
			};
			form.Show();
			Hide();
		}

		private void EmployeeDataGridView_UserDeletedRow(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
		{
			this.tableAdapterManager.EmployeeTableAdapter.Update(this.database1DataSet.Employee);
		}

		private void EmployeeFrame_Load(object sender, System.EventArgs e)
		{
			this.positionTableAdapter.Fill(this.database1DataSet.Position);
			this.sheduleTableAdapter.Fill(this.database1DataSet.Shedule);
			this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

		}

		private void EmployeeBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
		{
			this.Validate();
			this.employeeBindingSource.EndEdit();
			this.tableAdapterManager.EmployeeTableAdapter.Update(this.database1DataSet.Employee);
		}
	}
}
