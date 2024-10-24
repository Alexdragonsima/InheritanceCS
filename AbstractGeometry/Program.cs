using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);


			Rectangle rectangle = new Rectangle(100, 50, 400, 15, 5, Color.Red);
			rectangle.Info(e);

			Square square = new Square(75, 512, 15, 5, Color.DarkBlue);
			square.Info(e);

			Circle circle = new Circle(50, 600, 15, 5, Color.Yellow);
			circle.Info(e);

			IsoscalesTriangle i_triangle = new IsoscalesTriangle(50, 100, 700, 15, 5, Color.Green);
			i_triangle.Info(e);

			EquilateralTriangle e_triangle = new EquilateralTriangle(100, 400, 100, 3, Color.YellowGreen);
			e_triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
