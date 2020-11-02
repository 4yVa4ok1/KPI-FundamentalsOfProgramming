namespace Laboratory3.Forms.Employee
{
	partial class EmployeeForm
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
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label lastNameLabel;
			System.Windows.Forms.Label secondNameLabel;
			System.Windows.Forms.Label ageLabel;
			System.Windows.Forms.Label positionIdLabel;
			System.Windows.Forms.Label sheduleIdLabel;
			this.database1DataSet = new Laboratory3.Database1DataSet();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeeTableAdapter = new Laboratory3.Database1DataSetTableAdapters.EmployeeTableAdapter();
			this.tableAdapterManager = new Laboratory3.Database1DataSetTableAdapters.TableAdapterManager();
			this.positionTableAdapter = new Laboratory3.Database1DataSetTableAdapters.PositionTableAdapter();
			this.sheduleTableAdapter = new Laboratory3.Database1DataSetTableAdapters.SheduleTableAdapter();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txbxFirstName = new System.Windows.Forms.TextBox();
			this.txbxSecondName = new System.Windows.Forms.TextBox();
			this.txbxLastName = new System.Windows.Forms.TextBox();
			this.upDownAge = new System.Windows.Forms.NumericUpDown();
			this.cmbxPosition = new System.Windows.Forms.ComboBox();
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cmbxShedule = new System.Windows.Forms.ComboBox();
			this.sheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			firstNameLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			secondNameLabel = new System.Windows.Forms.Label();
			ageLabel = new System.Windows.Forms.Label();
			positionIdLabel = new System.Windows.Forms.Label();
			sheduleIdLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new System.Drawing.Point(78, 55);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(60, 13);
			firstNameLabel.TabIndex = 6;
			firstNameLabel.Text = "First Name:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new System.Drawing.Point(78, 81);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(61, 13);
			lastNameLabel.TabIndex = 8;
			lastNameLabel.Text = "Last Name:";
			// 
			// secondNameLabel
			// 
			secondNameLabel.AutoSize = true;
			secondNameLabel.Location = new System.Drawing.Point(78, 107);
			secondNameLabel.Name = "secondNameLabel";
			secondNameLabel.Size = new System.Drawing.Size(78, 13);
			secondNameLabel.TabIndex = 10;
			secondNameLabel.Text = "Second Name:";
			// 
			// ageLabel
			// 
			ageLabel.AutoSize = true;
			ageLabel.Location = new System.Drawing.Point(78, 133);
			ageLabel.Name = "ageLabel";
			ageLabel.Size = new System.Drawing.Size(29, 13);
			ageLabel.TabIndex = 12;
			ageLabel.Text = "Age:";
			// 
			// positionIdLabel
			// 
			positionIdLabel.AutoSize = true;
			positionIdLabel.Location = new System.Drawing.Point(78, 159);
			positionIdLabel.Name = "positionIdLabel";
			positionIdLabel.Size = new System.Drawing.Size(47, 13);
			positionIdLabel.TabIndex = 14;
			positionIdLabel.Text = "Position:";
			// 
			// sheduleIdLabel
			// 
			sheduleIdLabel.AutoSize = true;
			sheduleIdLabel.Location = new System.Drawing.Point(78, 185);
			sheduleIdLabel.Name = "sheduleIdLabel";
			sheduleIdLabel.Size = new System.Drawing.Size(49, 13);
			sheduleIdLabel.TabIndex = 16;
			sheduleIdLabel.Text = "Shedule:";
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
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(93, 208);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(220, 208);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txbxFirstName
			// 
			this.txbxFirstName.Location = new System.Drawing.Point(162, 52);
			this.txbxFirstName.Name = "txbxFirstName";
			this.txbxFirstName.Size = new System.Drawing.Size(158, 20);
			this.txbxFirstName.TabIndex = 19;
			// 
			// txbxSecondName
			// 
			this.txbxSecondName.Location = new System.Drawing.Point(162, 104);
			this.txbxSecondName.Name = "txbxSecondName";
			this.txbxSecondName.Size = new System.Drawing.Size(158, 20);
			this.txbxSecondName.TabIndex = 21;
			// 
			// txbxLastName
			// 
			this.txbxLastName.Location = new System.Drawing.Point(162, 78);
			this.txbxLastName.Name = "txbxLastName";
			this.txbxLastName.Size = new System.Drawing.Size(158, 20);
			this.txbxLastName.TabIndex = 22;
			// 
			// upDownAge
			// 
			this.upDownAge.Location = new System.Drawing.Point(162, 131);
			this.upDownAge.Name = "upDownAge";
			this.upDownAge.Size = new System.Drawing.Size(158, 20);
			this.upDownAge.TabIndex = 23;
			// 
			// cmbxPosition
			// 
			this.cmbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbxPosition.FormattingEnabled = true;
			this.cmbxPosition.Location = new System.Drawing.Point(162, 156);
			this.cmbxPosition.Name = "cmbxPosition";
			this.cmbxPosition.Size = new System.Drawing.Size(158, 21);
			this.cmbxPosition.TabIndex = 24;
			// 
			// positionBindingSource
			// 
			this.positionBindingSource.DataMember = "Position";
			this.positionBindingSource.DataSource = this.database1DataSet;
			// 
			// cmbxShedule
			// 
			this.cmbxShedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbxShedule.FormattingEnabled = true;
			this.cmbxShedule.Location = new System.Drawing.Point(162, 182);
			this.cmbxShedule.Name = "cmbxShedule";
			this.cmbxShedule.Size = new System.Drawing.Size(158, 21);
			this.cmbxShedule.TabIndex = 25;
			// 
			// sheduleBindingSource
			// 
			this.sheduleBindingSource.DataMember = "Shedule";
			this.sheduleBindingSource.DataSource = this.database1DataSet;
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(332, 236);
			this.Controls.Add(this.cmbxShedule);
			this.Controls.Add(this.cmbxPosition);
			this.Controls.Add(this.upDownAge);
			this.Controls.Add(this.txbxLastName);
			this.Controls.Add(this.txbxSecondName);
			this.Controls.Add(this.txbxFirstName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(firstNameLabel);
			this.Controls.Add(lastNameLabel);
			this.Controls.Add(secondNameLabel);
			this.Controls.Add(ageLabel);
			this.Controls.Add(positionIdLabel);
			this.Controls.Add(sheduleIdLabel);
			this.Name = "EmployeeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Сотрудник";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			this.Controls.SetChildIndex(sheduleIdLabel, 0);
			this.Controls.SetChildIndex(positionIdLabel, 0);
			this.Controls.SetChildIndex(ageLabel, 0);
			this.Controls.SetChildIndex(secondNameLabel, 0);
			this.Controls.SetChildIndex(lastNameLabel, 0);
			this.Controls.SetChildIndex(firstNameLabel, 0);
			this.Controls.SetChildIndex(this.btnSave, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(this.txbxFirstName, 0);
			this.Controls.SetChildIndex(this.txbxSecondName, 0);
			this.Controls.SetChildIndex(this.txbxLastName, 0);
			this.Controls.SetChildIndex(this.upDownAge, 0);
			this.Controls.SetChildIndex(this.cmbxPosition, 0);
			this.Controls.SetChildIndex(this.cmbxShedule, 0);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheduleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txbxFirstName;
		private System.Windows.Forms.TextBox txbxSecondName;
		private System.Windows.Forms.TextBox txbxLastName;
		private System.Windows.Forms.NumericUpDown upDownAge;
		private System.Windows.Forms.ComboBox cmbxPosition;
		private System.Windows.Forms.ComboBox cmbxShedule;
		private Database1DataSetTableAdapters.PositionTableAdapter positionTableAdapter;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private Database1DataSetTableAdapters.SheduleTableAdapter sheduleTableAdapter;
		private System.Windows.Forms.BindingSource sheduleBindingSource;
	}
}