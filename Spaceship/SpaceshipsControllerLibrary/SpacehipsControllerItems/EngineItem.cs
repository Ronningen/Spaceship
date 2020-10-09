using System;
using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class EngineItem : UserControl
	{
		public EngineItem(Engine engine, int level)
		{
			InitializeComponent();
			panelTabulation.Width *= level;
			titleLabel.Text += engine.type + engine.number;
			massLabel.Text += engine.M;
			mfLabel.Text += engine.MaxForce;
			forceController.Value = (int)(engine.ForceCoef * 100);
			directionController.DirectionChanged += (a) => engine.SetDireciton(a);
			directionController.Draw();
			forceController.Scroll += (o, e) => engine.ForceCoef = (decimal)forceController.Value / 100;
		}
	}
}
