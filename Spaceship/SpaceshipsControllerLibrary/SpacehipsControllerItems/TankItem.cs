using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class TankItem : UserControl
	{
		public TankItem(Tank tank, int level)
		{
			InitializeComponent();
			panelTabulation.Width *= level;
			titleLabel.Text += tank.type + tank.number;
			massLabel.Text += tank.M;
			mtfLabel.Text += tank.MTFCoef;
			tank.MassUpdated += () => massLabel.Text = "Mass " + tank.M;
		}
	}
}
