namespace Laboratory3.Forms.Shedule
{
	partial class SheduleForm
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
			System.Windows.Forms.Label descriptionLabel;
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.database1DataSet = new Laboratory3.Database1DataSet();
			this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sheduleTableAdapter = new Laboratory3.Database1DataSetTableAdapters.SheduleTableAdapter();
			this.tableAdapterManager = new Laboratory3.Database1DataSetTableAdapters.TableAdapterManager();
			this.txbxName = new System.Windows.Forms.TextBox();
			this.txbxDescription = new System.Windows.Forms.TextBox();
			nameLabel = new System.Windows.Forms.Label();
			descriptionLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(195, 166);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(85, 166);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
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
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(81, 92);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 23;
			nameLabel.Text = "Name:";
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.Location = new System.Drawing.Point(81, 130);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(63, 13);
			descriptionLabel.TabIndex = 25;
			descriptionLabel.Text = "Description:";
			// 
			// txbxName
			// 
			this.txbxName.Location = new System.Drawing.Point(146, 89);
			this.txbxName.Name = "txbxName";
			this.txbxName.Size = new System.Drawing.Size(133, 20);
			this.txbxName.TabIndex = 26;
			// 
			// txbxDescription
			// 
			this.txbxDescription.Location = new System.Drawing.Point(146, 127);
			this.txbxDescription.Name = "txbxDescription";
			this.txbxDescription.Size = new System.Drawing.Size(133, 20);
			this.txbxDescription.TabIndex = 27;
			// 
			// SheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(293, 207);
			this.Controls.Add(this.txbxDescription);
			this.Controls.Add(this.txbxName);
			this.Controls.Add(nameLabel);
			this.Controls.Add(descriptionLabel);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Name = "SheduleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "SheduleForm";
			this.Load += new System.EventHandler(this.SheduleForm_Load);
			this.Controls.SetChildIndex(this.btnSave, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(descriptionLabel, 0);
			this.Controls.SetChildIndex(nameLabel, 0);
			this.Controls.SetChildIndex(this.txbxName, 0);
			this.Controls.SetChildIndex(this.txbxDescription, 0);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource sheduleBindingSource;
		private Database1DataSetTableAdapters.SheduleTableAdapter sheduleTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox txbxName;
		private System.Windows.Forms.TextBox txbxDescription;
	}
}