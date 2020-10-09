using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class SpaceshipItem : UserControl
	{
		public Spaceship spaceship;
		public SpaceshipItem(Spaceship spaceship, ref int index)
		{
			InitializeComponent();
			this.spaceship = spaceship;
			titleLabel.Text += index;
			index++;
		}
	}
}
