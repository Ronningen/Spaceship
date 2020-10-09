using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class EngineItem : DetailItem
	{
		public EngineItem(Engine engine, int level) : base(engine, level)
		{
			InitializeComponent();
			mfLabel.Text += engine.MaxForce;
			forceController.Value = (int)(engine.ForceCoef * 100);
			forceController.Scroll += (o, e) => engine.ForceCoef = (decimal)forceController.Value / 100;
			directionController.DirectionChanged += (a) => engine.SetDireciton(a);
			directionController.Draw();
		}
	}
}
