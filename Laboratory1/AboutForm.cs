using System;
using System.Windows.Forms;

namespace Laboratory1
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();

			BindEvents();
		}

		/// <summary>
		/// Привязка событий формы
		/// </summary>
		/// <remarks>
		/// При привязке новых событий будет происходит расширение только этого метода, а не переполнения логики конструктора. Также реализация Single Responsibility
		/// </remarks>
		private void BindEvents()
		{
			btnExit.Click += BtnExit_Click;
		}

		/// <summary>
		/// Закрывает форму при нажатии
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
