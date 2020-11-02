namespace Laboratory3.Forms.Employee
{
	partial class EmployeeFrame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFrame));
			this.database1DataSet = new Laboratory3.Database1DataSet();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeeTableAdapter = new Laboratory3.Database1DataSetTableAdapters.EmployeeTableAdapter();
			this.tableAdapterManager = new Laboratory3.Database1DataSetTableAdapters.TableAdapterManager();
			this.positionTableAdapter = new Laboratory3.Database1DataSetTableAdapters.PositionTableAdapter();
			this.sheduleTableAdapter = new Laboratory3.Database1DataSetTableAdapters.SheduleTableAdapter();
			this.employeeDataGridView = new System.Windows.Forms.DataGridView();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SecondNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PositionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.SheduleColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
			this.employeeBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataMember = "Employee";
			this.employeeBindingSource.DataSource = this.database1DataSet;
			// 
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
			this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
			this.tableAdapterManager.SheduleTableAdapter = this.sheduleTableAdapter;
			this.tableAdapterManager.UpdateOrder = Laboratory3.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// positionTableAdapter
			// 
			this.positionTableAdapter.ClearBeforeFill = true;
			// 
			// sheduleTableAdapter
			// 
			this.sheduleTableAdapter.ClearBeforeFill = true;
			// 
			// employeeDataGridView
			// 
			this.employeeDataGridView.AllowUserToAddRows = false;
			this.employeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.employeeDataGridView.AutoGenerateColumns = false;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.SecondNameColumn,
            this.AgeColumn,
            this.PositionColumn,
            this.SheduleColumn});
			this.employeeDataGridView.DataSource = this.employeeBindingSource;
			this.employeeDataGridView.Location = new System.Drawing.Point(74, 52);
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.ReadOnly = true;
			this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.employeeDataGridView.Size = new System.Drawing.Size(726, 387);
			this.employeeDataGridView.TabIndex = 4;
			// 
			// IdColumn
			// 
			this.IdColumn.DataPropertyName = "Id";
			this.IdColumn.HeaderText = "Id";
			this.IdColumn.Name = "IdColumn";
			this.IdColumn.ReadOnly = true;
			this.IdColumn.Visible = false;
			// 
			// FirstNameColumn
			// 
			this.FirstNameColumn.DataPropertyName = "FirstName";
			this.FirstNameColumn.HeaderText = "Имя";
			this.FirstNameColumn.Name = "FirstNameColumn";
			this.FirstNameColumn.ReadOnly = true;
			// 
			// LastNameColumn
			// 
			this.LastNameColumn.DataPropertyName = "LastName";
			this.LastNameColumn.HeaderText = "Фамилия";
			this.LastNameColumn.Name = "LastNameColumn";
			this.LastNameColumn.ReadOnly = true;
			// 
			// SecondNameColumn
			// 
			this.SecondNameColumn.DataPropertyName = "SecondName";
			this.SecondNameColumn.HeaderText = "Отчество";
			this.SecondNameColumn.Name = "SecondNameColumn";
			this.SecondNameColumn.ReadOnly = true;
			// 
			// AgeColumn
			// 
			this.AgeColumn.DataPropertyName = "Age";
			this.AgeColumn.HeaderText = "Возраст";
			this.AgeColumn.Name = "AgeColumn";
			this.AgeColumn.ReadOnly = true;
			// 
			// PositionColumn
			// 
			this.PositionColumn.DataPropertyName = "PositionId";
			this.PositionColumn.DataSource = this.positionBindingSource;
			this.PositionColumn.DisplayMember = "Name";
			this.PositionColumn.HeaderText = "Должность";
			this.PositionColumn.Name = "PositionColumn";
			this.PositionColumn.ReadOnly = true;
			this.PositionColumn.ValueMember = "Id";
			// 
			// positionBindingSource
			// 
			this.positionBindingSource.DataMember = "Position";
			this.positionBindingSource.DataSource = this.database1DataSet;
			// 
			// SheduleColumn
			// 
			this.SheduleColumn.DataPropertyName = "SheduleId";
			this.SheduleColumn.DataSource = this.sheduleBindingSource;
			this.SheduleColumn.DisplayMember = "Name";
			this.SheduleColumn.HeaderText = "График";
			this.SheduleColumn.Name = "SheduleColumn";
			this.SheduleColumn.ReadOnly = true;
			this.SheduleColumn.ValueMember = "Id";
			// 
			// sheduleBindingSource
			// 
			this.sheduleBindingSource.DataMember = "Shedule";
			this.sheduleBindingSource.DataSource = this.database1DataSet;
			// 
			// btnAdd
			// 
			this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.RightToLeftAutoMirrorImage = true;
			this.btnAdd.Size = new System.Drawing.Size(23, 22);
			this.btnAdd.Text = "Добавить";
			// 
			// btnEdit
			// 
			this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 22);
			this.btnEdit.Text = "Edit";
			// 
			// employeeBindingNavigator
			// 
			this.employeeBindingNavigator.AddNewItem = null;
			this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
			this.employeeBindingNavigator.CountItem = null;
			this.employeeBindingNavigator.DeleteItem = null;
			this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit});
			this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 24);
			this.employeeBindingNavigator.MoveFirstItem = null;
			this.employeeBindingNavigator.MoveLastItem = null;
			this.employeeBindingNavigator.MoveNextItem = null;
			this.employeeBindingNavigator.MovePreviousItem = null;
			this.employeeBindingNavigator.Name = "employeeBindingNavigator";
			this.employeeBindingNavigator.PositionItem = null;
			this.employeeBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.employeeBindingNavigator.TabIndex = 4;
			// 
			// EmployeeFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 437);
			this.Controls.Add(this.employeeBindingNavigator);
			this.Controls.Add(this.employeeDataGridView);
			this.Name = "EmployeeFrame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Сотрудники";
			this.Load += new System.EventHandler(this.EmployeeFrame_Load);
			this.Controls.SetChildIndex(this.employeeDataGridView, 0);
			this.Controls.SetChildIndex(this.employeeBindingNavigator, 0);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
			this.employeeBindingNavigator.ResumeLayout(false);
			this.employeeBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private Database1DataSetTableAdapters.SheduleTableAdapter sheduleTableAdapter;
		private System.Windows.Forms.DataGridView employeeDataGridView;
		private System.Windows.Forms.BindingSource sheduleBindingSource;
		private Database1DataSetTableAdapters.PositionTableAdapter positionTableAdapter;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn SecondNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn PositionColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn SheduleColumn;
	}
}