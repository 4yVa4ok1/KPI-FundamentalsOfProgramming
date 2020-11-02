using Laboratory3.Forms.Employee;
using Laboratory3.Forms.Position;
using Laboratory3.Forms.Shedule;
using System;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using Laboratory3.Properties;
using System.Linq;

namespace Laboratory3
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			BindEvents();
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			//Закрытие программы при нажатии на крестик в правом верхнем углу
			Environment.Exit(0);
		}

		/// <summary>
		/// Проверка TextBox на наличие значения
		/// </summary>
		/// <param name="textBox"></param>
		/// <returns>Если пустой - false</returns>
		protected bool ValidateEmptyTextBox(TextBox textBox)
		{
			if (string.IsNullOrEmpty(textBox.Text))
			{
				MessageBox.Show(Resources.EmptyField, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		/// <summary>
		/// Проверка всех Control формы за раз. Используется в методе сохранения формы
		/// </summary>
		/// <returns></returns>
		protected virtual bool ValidateControls()
		{
			var textboxes = this.Controls.OfType<TextBox>();

			foreach (TextBox textBox in textboxes)
			{
				if (!this.ValidateEmptyTextBox(textBox))
				{
					return false;
				}
			}

			return true;
		}

		private void BindEvents()
		{
			exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;

			lnkEmployees.Click += LnkEmployees_Click;
			lnkPositions.Click += LnkPositions_Click;
			lnkShedules.Click += LnkShedules_Click;
		}

		private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Открытие файла лабораторной работы при нажатии на Помощь
			byte[] myFile = Resources.Лаб3;

			var templateFullPath = Path.ChangeExtension(Path.GetTempFileName(), ".doc");
			using (FileStream tempFile = File.Create(templateFullPath))
				tempFile.Write(myFile, 0, myFile.Length);
			var app = new Word.Application { Visible = true };
			app.Documents.Add(Template: templateFullPath, Visible: true);
			File.Delete(templateFullPath);
		}

		private void LnkEmployees_Click(object sender, EventArgs e)
		{
			var form = new EmployeeFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void LnkPositions_Click(object sender, EventArgs e)
		{
			var form = new PositionFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void LnkShedules_Click(object sender, EventArgs e)
		{
			var form = new SheduleFrame
			{
				Location = this.Location
			};
			form.Show();
			Hide();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
