using System.Drawing;
using System.Windows.Forms;

namespace Laboratory7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			var pen = new Pen(Color.Coral, 5);
			e.Graphics.DrawLine(pen, 0, 0, 50, 0);
			e.Graphics.DrawLine(pen, 25, 0, 25, 50);

			pen.Color = Color.Blue;
			e.Graphics.DrawLine(pen, 60, 0, 60, 50);
			e.Graphics.DrawLine(pen, 60, 50, 100, 0);
			e.Graphics.DrawLine(pen, 100, 0, 100, 50);

			pen.Color = Color.Black;
			e.Graphics.DrawLine(pen, 110, 0, 110, 50);
			e.Graphics.DrawLine(pen, 110, 0, 130, 25);
			e.Graphics.DrawLine(pen, 130, 25, 150, 0);
			e.Graphics.DrawLine(pen, 150, 0, 150, 50);

			pen.Color = Color.Aquamarine;
			e.Graphics.DrawLine(pen, 160, 0, 170, 25);
			e.Graphics.DrawLine(pen, 180, 0, 160, 50);

			pen.Color = Color.Red;
			e.Graphics.DrawLine(pen, 190, 0, 190, 50);
			e.Graphics.DrawArc(pen, new Rectangle(190, 0, 10, 25), 270, 250);

			pen.Color = Color.Aqua;
			e.Graphics.DrawLine(pen, 0, 60, 0, 110);
			e.Graphics.DrawLine(pen, 0, 60, 25, 60);

			pen.Color = Color.Crimson;
			e.Graphics.DrawLine(pen, 35, 60, 35, 110);
			e.Graphics.DrawLine(pen, 35, 110, 75, 60);
			e.Graphics.DrawLine(pen, 75, 60, 75, 110);

			pen.Color = Color.Cornsilk;
			e.Graphics.DrawLine(pen, 85, 60, 85, 110);
			e.Graphics.DrawLine(pen, 85, 60, 125, 60);
			e.Graphics.DrawLine(pen, 125, 60, 125, 110);

			pen.Color = Color.YellowGreen;
			e.Graphics.DrawLine(pen, 135, 60, 185, 60);
			e.Graphics.DrawLine(pen, 160, 60, 160, 110);

			pen.Color = Color.ForestGreen;
			e.Graphics.DrawLine(pen, 195, 60, 195, 110);
			e.Graphics.DrawLine(pen, 195, 60, 220, 60);
			e.Graphics.DrawLine(pen, 195, 85, 220, 85);
			e.Graphics.DrawLine(pen, 195, 110, 220, 110);

			pen.Color = Color.Firebrick;
			e.Graphics.DrawLine(pen, 230, 60, 230, 110);
			e.Graphics.DrawLine(pen, 230, 85, 255, 85);
			e.Graphics.DrawLine(pen, 255, 60, 255, 110);

			pen.Color = Color.Fuchsia;
			e.Graphics.DrawLine(pen, 265, 60, 265, 110);
			e.Graphics.DrawLine(pen, 290, 60, 265, 85);
			e.Graphics.DrawLine(pen, 265, 85, 290, 110);

			pen.Color = Color.CornflowerBlue;
			e.Graphics.DrawArc(pen, new Rectangle(300, 60, 25, 50), 0, 360);
		}
	}
}
