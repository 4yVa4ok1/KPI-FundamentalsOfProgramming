namespace Laboratory3.Forms.Shedule
{
	partial class SheduleFrame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheduleFrame));
			this.database1DataSet = new Laboratory3.Database1DataSet();
			this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sheduleTableAdapter = new Laboratory3.Database1DataSetTableAdapters.SheduleTableAdapter();
			this.tableAdapterManager = new Laboratory3.Database1DataSetTableAdapters.TableAdapterManager();
			this.sheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.sheduleDataGridView = new System.Windows.Forms.DataGridView();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingNavigator)).BeginInit();
			this.sheduleBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sheduleDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sheduleBindingSource
			// 
			this.sheduleBindingSource.DataMember = "Shedule";
			this.sheduleBindingSource.DataSource = this.database1DataSet;
			// 
			// sheduleTableAdapter
			// 
			this.sheduleTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeeTableAdapter = null;
			this.tableAdapterManager.PositionTableAdapter = null;
			this.tableAdapterManager.SheduleTableAdapter = this.sheduleTableAdapter;
			this.tableAdapterManager.UpdateOrder = Laboratory3.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// sheduleBindingNavigator
			// 
			this.sheduleBindingNavigator.AddNewItem = null;
			this.sheduleBindingNavigator.BindingSource = this.sheduleBindingSource;
			this.sheduleBindingNavigator.CountItem = null;
			this.sheduleBindingNavigator.DeleteItem = null;
			this.sheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnEdit});
			this.sheduleBindingNavigator.Location = new System.Drawing.Point(0, 24);
			this.sheduleBindingNavigator.MoveFirstItem = null;
			this.sheduleBindingNavigator.MoveLastItem = null;
			this.sheduleBindingNavigator.MoveNextItem = null;
			this.sheduleBindingNavigator.MovePreviousItem = null;
			this.sheduleBindingNavigator.Name = "sheduleBindingNavigator";
			this.sheduleBindingNavigator.PositionItem = null;
			this.sheduleBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.sheduleBindingNavigator.TabIndex = 4;
			this.sheduleBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnAdd
			// 
			this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Name = "bindingNavigatorAddNewItem";
			this.btnAdd.RightToLeftAutoMirrorImage = true;
			this.btnAdd.Size = new System.Drawing.Size(23, 22);
			this.btnAdd.Text = "Add new";
			// 
			// sheduleDataGridView
			// 
			this.sheduleDataGridView.AllowUserToAddRows = false;
			this.sheduleDataGridView.AutoGenerateColumns = false;
			this.sheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.DescriptionColumn});
			this.sheduleDataGridView.DataSource = this.sheduleBindingSource;
			this.sheduleDataGridView.Location = new System.Drawing.Point(74, 52);
			this.sheduleDataGridView.Name = "sheduleDataGridView";
			this.sheduleDataGridView.ReadOnly = true;
			this.sheduleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.sheduleDataGridView.Size = new System.Drawing.Size(726, 385);
			this.sheduleDataGridView.TabIndex = 4;
			// 
			// btnEdit
			// 
			this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 22);
			this.btnEdit.Text = "toolStripButton1";
			// 
			// IdColumn
			// 
			this.IdColumn.DataPropertyName = "Id";
			this.IdColumn.HeaderText = "Id";
			this.IdColumn.Name = "IdColumn";
			this.IdColumn.ReadOnly = true;
			this.IdColumn.Visible = false;
			// 
			// NameColumn
			// 
			this.NameColumn.DataPropertyName = "Name";
			this.NameColumn.HeaderText = "Название";
			this.NameColumn.Name = "NameColumn";
			this.NameColumn.ReadOnly = true;
			this.NameColumn.Width = 200;
			// 
			// DescriptionColumn
			// 
			this.DescriptionColumn.DataPropertyName = "Description";
			this.DescriptionColumn.HeaderText = "Описание";
			this.DescriptionColumn.Name = "DescriptionColumn";
			this.DescriptionColumn.ReadOnly = true;
			this.DescriptionColumn.Width = 400;
			// 
			// SheduleFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 437);
			this.Controls.Add(this.sheduleDataGridView);
			this.Controls.Add(this.sheduleBindingNavigator);
			this.Name = "SheduleFrame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Расписания";
			this.Load += new System.EventHandler(this.SheduleFrame_Load);
			this.Controls.SetChildIndex(this.sheduleBindingNavigator, 0);
			this.Controls.SetChildIndex(this.sheduleDataGridView, 0);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingNavigator)).EndInit();
			this.sheduleBindingNavigator.ResumeLayout(false);
			this.sheduleBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sheduleDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource sheduleBindingSource;
		private Database1DataSetTableAdapters.SheduleTableAdapter sheduleTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator sheduleBindingNavigator;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.DataGridView sheduleDataGridView;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
	}
}