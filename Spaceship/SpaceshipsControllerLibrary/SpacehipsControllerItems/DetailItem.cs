using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class DetailItem : UserControl
	{
		public DetailItem(Detail detail, int level)
		{
			InitializeComponent();
			panelTabulation.Width *= level;
			titleLabel.Text += detail.type + detail.number;
			massLabel.Text += detail.M;
		}
	}
}
