using System;
using System.Windows.Forms;

namespace Laboratory5
{
	public partial class Form1 : Form
	{
		double first;
		double second;
		double third;
		double fourth;
		double fifth;
		double sixth;
		double answer;

		public Form1()
		{
			InitializeComponent();

			this.upDownNumber.Controls.RemoveAt(0);
			this.upDownNumber.ValueChanged += UpDownNumber_ValueChanged;
		}

		private void UpDownNumber_ValueChanged(object sender, EventArgs e)
		{
			var number = Decimal.ToDouble(((NumericUpDown)sender).Value);
			this.CountFirst(number);
			this.CountSecond(number);
			this.CountThird();
			this.CountFourth(number);
			this.CountFifth(number);
			this.CountSixth();
			this.CountAnswer();
		}

		private void CountFirst(double number)
		{
			this.first = Math.Sqrt((2 * number) + Math.Pow(Math.E, Math.Sin(number) + 1));
			this.txbxFirst.Text = this.first.ToString();
		}

		private void CountSecond(double number)
		{
			this.second = 2 + Math.Pow(Math.E, Math.Sin(number) + 1);
			this.txbxSecond.Text = this.second.ToString();
		}

		private void CountThird()
		{
			this.third = this.first / this.second;
			this.txbxThird.Text = this.third.ToString();
		}

		private void CountFourth(double number)
		{
			this.fourth = this.third * Math.Tan(number);
			this.txbxFourth.Text = this.fourth.ToString();
		}

		private void CountFifth(double number)
		{
			this.fifth = Math.Abs(Math.Pow(Math.E, Math.Sin(number)));
			this.txbxFifth.Text = this.fifth.ToString();
		}

		private void CountSixth()
		{
			this.sixth = this.fourth + fifth;
			this.txbxSixth.Text = this.sixth.ToString();
		}

		private void CountAnswer()
		{
			this.answer = this.sixth * 2;
			this.txbxAnswer.Text = this.answer.ToString();
		}
	}
}
