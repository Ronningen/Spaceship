using System.Windows.Forms;
using SpaceshipModelLib;

namespace SpaceshipsControllerLib.SpacehipsControllerItems
{
	internal partial class SpaceshipItem : UserControl
	{
		public SpaceshipItem(Spaceship spaceship, ref int index)
		{
			InitializeComponent();
			titleLabel.Text += index;
			index++;
		}
	}
}
