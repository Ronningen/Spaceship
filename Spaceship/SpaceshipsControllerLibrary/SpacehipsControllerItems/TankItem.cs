
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class TankItem : DetailItem
	{
		public TankItem(Tank tank, int level) : base(tank, level)
		{
			InitializeComponent();
			mtfLabel.Text += tank.MTFCoef;
			tank.MassUpdated += () => massLabel.Text = "Mass " + tank.M;
		}
	}
}
