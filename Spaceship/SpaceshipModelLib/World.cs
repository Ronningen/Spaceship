using System.Drawing;
using System.Collections.Generic;

using SpaceshipModelLib.ShortMath;

namespace SpaceshipModelLib
{
	public class World
	{
		public List<Spaceship> spaceships;
		public int editingIndex;
		private int width, height;

		private Bitmap frame;
		private Graphics g;

		public World(int width, int height)
		{
			spaceships = new List<Spaceship>();
			ChangeSize(width, height);
			editingIndex = -1;
		}

		public void ChangeSize(int width, int height)
		{
			this.width = width;
			this.height = height;
			frame = new Bitmap(width, height);
			g = Graphics.FromImage(frame);
		}

		public Image NextFrame()
		{
			g.Clear(Color.Transparent);
			foreach (Spaceship spaceship in spaceships)
			{
				spaceship.Evulate(width, height);
				spaceship.Show(g, editingIndex < 0 || spaceship != spaceships[editingIndex]);
			}

			return frame;
		}

		public void Detach(Detail detail)
		{
			foreach (Spaceship spaceship in spaceships)
				if (spaceship.Detach(detail) is Spaceship newOne)
				{
					spaceships.Add(newOne);
					return;
				}
		}

		public void Attach(Detail detail, Vector position)
		{
			Detail clone = detail.Clone(position);
			if (editingIndex < 0 || !spaceships[editingIndex].Attach(clone))
			{
				spaceships.Add(new Spaceship(clone));
				editingIndex = spaceships.Count - 1;
			}
		}
	}
}
