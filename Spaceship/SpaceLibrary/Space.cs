using System;
using System.Drawing;
using System.Windows.Forms;

using SpaceshipModel;
using SpaceshipModel.ShortMath;

namespace SpaceLibrary
{
	public partial class Space : UserControl
	{
		public World world;
		public event Action DetailAttached;

		public Space()
		{
			InitializeComponent();
			world = new World(spacePictureBox.Width, spacePictureBox.Height);
		}

		private void Space_DragDrop(object sender, DragEventArgs e)
		{
			Detail detail = (Detail)(e.Data.GetData(typeof(Detail)) 
									?? e.Data.GetData(typeof(Engine)) 
									?? e.Data.GetData(typeof(Tank)));
			if (detail != null)
			{
				Point p = PointToClient(new Point(e.X, e.Y));
				world.Attach(detail, (p.X - 2 , p.Y - 17) - detail.CentreInLook);
				DetailAttached?.Invoke();
			}
		}

		private void Space_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void spacePictureBox_SizeChanged(object sender, EventArgs e)
		{
			world?.ChangeSize(spacePictureBox.Width, spacePictureBox.Height);
		}

		private void worldTimer_Tick(object sender, EventArgs e)
		{
			spacePictureBox.Image = world.NextFrame();
		}
	}
}
