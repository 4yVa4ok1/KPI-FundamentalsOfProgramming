namespace Laboratory3.Forms.Position
{
	partial class PositionForm
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
			System.Windows.Forms.Label nameLabel;
			this.database1DataSet = new Laboratory3.Database1DataSet();
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.positionTableAdapter = new Laboratory3.Database1DataSetTableAdapters.PositionTableAdapter();
			this.tableAdapterManager = new Laboratory3.Database1DataSetTableAdapters.TableAdapterManager();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txbxName = new System.Windows.Forms.TextBox();
			nameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(83, 146);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 6;
			nameLabel.Text = "Name:";
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
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(204, 183);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(86, 183);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// txbxName
			// 
			this.txbxName.Location = new System.Drawing.Point(127, 143);
			this.txbxName.Name = "txbxName";
			this.txbxName.Size = new System.Drawing.Size(152, 20);
			this.txbxName.TabIndex = 21;
			// 
			// PositionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(291, 218);
			this.Controls.Add(this.txbxName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(nameLabel);
			this.Name = "PositionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "PositionForm";
			this.Load += new System.EventHandler(this.PositionForm_Load);
			this.Controls.SetChildIndex(nameLabel, 0);
			this.Controls.SetChildIndex(this.btnSave, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(this.txbxName, 0);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private Database1DataSetTableAdapters.PositionTableAdapter positionTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txbxName;
	}
}