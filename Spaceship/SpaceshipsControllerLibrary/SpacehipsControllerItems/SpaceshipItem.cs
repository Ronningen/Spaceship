using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
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
