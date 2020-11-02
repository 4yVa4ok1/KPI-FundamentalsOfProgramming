namespace Laboratory3.Forms.Shedule
{
	public partial class SheduleFrame : Main
	{
		public SheduleFrame()
		{
			InitializeComponent();

			BindEvents();
		}

		private void BindEvents()
		{
			this.btnAdd.Click += BtnAdd_Click;
			this.btnEdit.Click += BtnEdit_Click;
			this.sheduleDataGridView.UserDeletedRow += SheduleDataGridView_UserDeletedRow;
		}

		private void BtnAdd_Click(object sender, System.EventArgs e)
		{
			var form = new SheduleForm
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void BtnEdit_Click(object sender, System.EventArgs e)
		{
			var id = (int)this.sheduleDataGridView.CurrentRow.Cells["IdColumn"].Value;
			var form = new SheduleForm
			{
				Location = this.Location,
				Tag = id
			};
			form.Show();
			Hide();
		}

		private void SheduleDataGridView_UserDeletedRow(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
		{
			this.tableAdapterManager.SheduleTableAdapter.Update(this.database1DataSet.Shedule);
		}

		private void SheduleFrame_Load(object sender, System.EventArgs e)
		{
			this.sheduleTableAdapter.Fill(this.database1DataSet.Shedule);

		}
	}
}
