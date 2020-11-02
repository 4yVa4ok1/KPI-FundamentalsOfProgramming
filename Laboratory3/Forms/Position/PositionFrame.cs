namespace Laboratory3.Forms.Position
{
	public partial class PositionFrame : Main
	{
		public PositionFrame()
		{
			InitializeComponent();

			BindEvents();
		}

		private void BindEvents()
		{
			this.btnAdd.Click += BtnAdd_Click;
			this.btnEdit.Click += BtnEdit_Click;
			this.positionDataGridView.UserDeletedRow += PositionDataGridView_UserDeletedRow;
		}

		private void BtnAdd_Click(object sender, System.EventArgs e)
		{
			var form = new PositionForm
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void BtnEdit_Click(object sender, System.EventArgs e)
		{
			var id = (int)this.positionDataGridView.CurrentRow.Cells["IdColumn"].Value;
			var form = new PositionForm
			{
				Location = this.Location,
				Tag = id
			};
			form.Show();
			Hide();
		}

		private void PositionDataGridView_UserDeletedRow(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
		{
			this.tableAdapterManager.PositionTableAdapter.Update(this.database1DataSet.Position);
		}

		private void PositionFrame_Load(object sender, System.EventArgs e)
		{
			this.positionTableAdapter.Fill(this.database1DataSet.Position);
		}
	}
}
