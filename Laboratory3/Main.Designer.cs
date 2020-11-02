namespace Laboratory3
{
	partial class Main
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.programmToolStripMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuHeader = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lnkEmployees = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lnkPositions = new System.Windows.Forms.LinkLabel();
			this.lnkShedules = new System.Windows.Forms.LinkLabel();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuHeader,
            this.aboutToolStripMenuHeader});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip2";
			// 
			// programmToolStripMenuHeader
			// 
			this.programmToolStripMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.programmToolStripMenuHeader.Name = "programmToolStripMenuHeader";
			this.programmToolStripMenuHeader.Size = new System.Drawing.Size(75, 20);
			this.programmToolStripMenuHeader.Text = "Програма";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.exitToolStripMenuItem.Text = "Выход";
			// 
			// aboutToolStripMenuHeader
			// 
			this.aboutToolStripMenuHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.aboutToolStripMenuHeader.Name = "aboutToolStripMenuHeader";
			this.aboutToolStripMenuHeader.Size = new System.Drawing.Size(94, 20);
			this.aboutToolStripMenuHeader.Text = "О программе";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.helpToolStripMenuItem.Text = "Помощь";
			// 
			// lnkEmployees
			// 
			this.lnkEmployees.ActiveLinkColor = System.Drawing.Color.Black;
			this.lnkEmployees.AutoSize = true;
			this.lnkEmployees.LinkColor = System.Drawing.Color.Black;
			this.lnkEmployees.Location = new System.Drawing.Point(3, 103);
			this.lnkEmployees.Name = "lnkEmployees";
			this.lnkEmployees.Size = new System.Drawing.Size(66, 13);
			this.lnkEmployees.TabIndex = 2;
			this.lnkEmployees.TabStop = true;
			this.lnkEmployees.Text = "Сотрудники";
			this.lnkEmployees.VisitedLinkColor = System.Drawing.Color.Black;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.Menu;
			this.panel1.Controls.Add(this.lnkPositions);
			this.panel1.Controls.Add(this.lnkShedules);
			this.panel1.Controls.Add(this.lnkEmployees);
			this.panel1.Location = new System.Drawing.Point(0, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(72, 435);
			this.panel1.TabIndex = 3;
			// 
			// lnkPositions
			// 
			this.lnkPositions.ActiveLinkColor = System.Drawing.Color.Black;
			this.lnkPositions.AutoSize = true;
			this.lnkPositions.LinkColor = System.Drawing.Color.Black;
			this.lnkPositions.Location = new System.Drawing.Point(3, 134);
			this.lnkPositions.Name = "lnkPositions";
			this.lnkPositions.Size = new System.Drawing.Size(65, 13);
			this.lnkPositions.TabIndex = 4;
			this.lnkPositions.TabStop = true;
			this.lnkPositions.Text = "Должности";
			this.lnkPositions.VisitedLinkColor = System.Drawing.Color.Black;
			// 
			// lnkShedules
			// 
			this.lnkShedules.ActiveLinkColor = System.Drawing.Color.Black;
			this.lnkShedules.AutoSize = true;
			this.lnkShedules.LinkColor = System.Drawing.Color.Black;
			this.lnkShedules.Location = new System.Drawing.Point(3, 164);
			this.lnkShedules.Name = "lnkShedules";
			this.lnkShedules.Size = new System.Drawing.Size(68, 13);
			this.lnkShedules.TabIndex = 3;
			this.lnkShedules.TabStop = true;
			this.lnkShedules.Text = "Расписания";
			this.lnkShedules.VisitedLinkColor = System.Drawing.Color.Black;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(800, 416);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Отдел кадров";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuHeader;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuHeader;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.LinkLabel lnkEmployees;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel lnkPositions;
		private System.Windows.Forms.LinkLabel lnkShedules;
	}
}

