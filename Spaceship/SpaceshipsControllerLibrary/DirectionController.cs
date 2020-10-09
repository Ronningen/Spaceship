using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;

namespace SpaceshipsControllerLibrary
{
	public partial class DirectionController : UserControl
	{
		private float angle;
		private bool changing;
		public event Action<float> DirectionChanged;

		private Bitmap b;
		private Graphics g;

		public DirectionController()
		{
			angle = 0;
			b = new Bitmap(Height, Height);
			g = Graphics.FromImage(b);
			InitializeComponent();
		}

		private void controllerPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				changing = true;
		}

		private void controllerPictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (changing)
			{
				angle = (float)Atan2(e.Y - Width / 2, e.X - Height / 2);
				g.Clear(Color.Transparent);
				Draw();
				DirectionChanged?.Invoke(angle);
			}
		}

		public void Draw()
		{
			g.DrawEllipse(new Pen(Brushes.Black, 6), 3, 3, Width - 6, Height - 6);
			g.DrawEllipse(new Pen(Brushes.LightGray, 4), 3, 3, Width - 6, Height - 6);
			g.DrawLine(new Pen(Brushes.Blue, 2), Width / 2, Height / 2, Width / 2 * (1 + (float)Cos(angle)), Height / 2 * (1 + (float)Sin(angle)));
			controllerPictureBox.Image = b;
		}

		private void controllerPictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				changing = false;
		}

		private void controllerPictureBox_MouseLeave(object sender, EventArgs e)
		{
			changing = false;
		}
	}
}
