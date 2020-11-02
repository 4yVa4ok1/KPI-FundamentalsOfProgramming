namespace Laboratory3.Forms.Position
{
	partial class PositionFrame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionFrame));
			this.database1DataSet = new Laboratory3.Database1DataSet();
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.positionTableAdapter = new Laboratory3.Database1DataSetTableAdapters.PositionTableAdapter();
			this.tableAdapterManager = new Laboratory3.Database1DataSetTableAdapters.TableAdapterManager();
			this.positionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.positionDataGridView = new System.Windows.Forms.DataGridView();
			this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingNavigator)).BeginInit();
			this.positionBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// positionBindingSource
			// 
			this.positionBindingSource.DataMember = "Position";
			this.positionBindingSource.DataSource = this.database1DataSet;
			// 
			// positionTableAdapter
			// 
			this.positionTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeeTableAdapter = null;
			this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
			this.tableAdapterManager.SheduleTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Laboratory3.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// positionBindingNavigator
			// 
			this.positionBindingNavigator.AddNewItem = null;
			this.positionBindingNavigator.BindingSource = this.positionBindingSource;
			this.positionBindingNavigator.CountItem = null;
			this.positionBindingNavigator.DeleteItem = null;
			this.positionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit});
			this.positionBindingNavigator.Location = new System.Drawing.Point(0, 24);
			this.positionBindingNavigator.MoveFirstItem = null;
			this.positionBindingNavigator.MoveLastItem = null;
			this.positionBindingNavigator.MoveNextItem = null;
			this.positionBindingNavigator.MovePreviousItem = null;
			this.positionBindingNavigator.Name = "positionBindingNavigator";
			this.positionBindingNavigator.PositionItem = null;
			this.positionBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.positionBindingNavigator.TabIndex = 4;
			this.positionBindingNavigator.Text = "bindingNavigator1";
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
			this.btnEdit.Text = "Изменить";
			// 
			// positionDataGridView
			// 
			this.positionDataGridView.AllowUserToAddRows = false;
			this.positionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.positionDataGridView.AutoGenerateColumns = false;
			this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn});
			this.positionDataGridView.DataSource = this.positionBindingSource;
			this.positionDataGridView.Location = new System.Drawing.Point(74, 49);
			this.positionDataGridView.Name = "positionDataGridView";
			this.positionDataGridView.ReadOnly = true;
			this.positionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.positionDataGridView.Size = new System.Drawing.Size(726, 386);
			this.positionDataGridView.TabIndex = 4;
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
			this.NameColumn.Width = 550;
			// 
			// PositionFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 437);
			this.Controls.Add(this.positionDataGridView);
			this.Controls.Add(this.positionBindingNavigator);
			this.Name = "PositionFrame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Должности";
			this.Load += new System.EventHandler(this.PositionFrame_Load);
			this.Controls.SetChildIndex(this.positionBindingNavigator, 0);
			this.Controls.SetChildIndex(this.positionDataGridView, 0);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingNavigator)).EndInit();
			this.positionBindingNavigator.ResumeLayout(false);
			this.positionBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private Database1DataSetTableAdapters.PositionTableAdapter positionTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator positionBindingNavigator;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.DataGridView positionDataGridView;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
	}
}