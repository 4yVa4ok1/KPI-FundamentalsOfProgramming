using System.Drawing;
using System.Windows.Forms;

namespace Laboratoy9
{
	public partial class Form1 : Form
	{
		private const int Level = 5;

		public Form1()
		{
			InitializeComponent();
		}

		private void DrawTriangle(int level, PointF top, PointF left, PointF right, Graphics graphics)
		{
			//якорь рекурсии. Также отрисовка внешнего треугольника
			if (level == 0)
			{
				PointF[] points = new PointF[4]
				{
					top, right, left, top
				};
				graphics.DrawLines(new Pen(Color.Violet, 3), points);
			}
			else
			{
				//вычисляем среднюю точку
				var leftMid = MidPoint(top, left); //левая сторона
				var rightMid = MidPoint(top, right); //правая сторона
				var topMid = MidPoint(left, right); //основание
													//рекурсивно вызываем функцию для каждого и 3 треугольников
				DrawTriangle(level - 1, top, leftMid, rightMid, graphics);
				DrawTriangle(level - 1, leftMid, left, topMid, graphics);
				DrawTriangle(level - 1, rightMid, topMid, right, graphics);
			}
		}

		private PointF MidPoint(PointF p1, PointF p2)
		{
			return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//вершины треугольника
			PointF topPoint = new PointF(1000 / 2f, 0);
			PointF leftPoint = new PointF(0, 1000);
			PointF rightPoint = new PointF(1000, 1000);
			//вызываем функцию отрисовки
			DrawTriangle(Level, topPoint, leftPoint, rightPoint, e.Graphics);
		}
	}
}
