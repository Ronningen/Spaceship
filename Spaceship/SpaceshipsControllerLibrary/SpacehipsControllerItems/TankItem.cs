using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class TankItem : UserControl
	{
		Tank tank;

		public TankItem(Tank tank, int level)
		{
			InitializeComponent();
			this.tank = tank;
			panelTabulation.Width *= level;
			titleLabel.Text += tank.type + tank.number;
			massLabel.Text += tank.M;
			tank.MassUpdated += () => massLabel.Text = "Mass " + tank.M;
		}
	}
}
