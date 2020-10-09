using System;
using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class EngineItem : UserControl
	{
		private Engine engine;
		public EngineItem(Engine engine, int level)
		{
			InitializeComponent();
			this.engine = engine;
			panelTabulation.Width *= level;
			titleLabel.Text += engine.type + engine.number;
			massLabel.Text += engine.M;
			forceController.Value = (int)(engine.ForceCoef * 100);
		}

		private void forceController_Scroll(object sender, EventArgs e)
		{
			engine.ForceCoef = (decimal)forceController.Value / 100;
		}
	}
}
