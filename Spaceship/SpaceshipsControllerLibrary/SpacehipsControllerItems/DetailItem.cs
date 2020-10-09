using System.Windows.Forms;
using SpaceshipModel;

namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	internal partial class DetailItem : UserControl
	{
		private Detail detail;
		private int level;
		public DetailItem(Detail detail, int level)
		{
			InitializeComponent();
			this.detail = detail;
			this.level = level;
			panelTabulation.Width *= level;
			titleLabel.Text += detail.type + detail.number;
			massLabel.Text += detail.M;
		}

		public static implicit operator EngineItem(DetailItem item) => new EngineItem(item.detail as Engine, item.level);
		public static implicit operator TankItem(DetailItem item) => new TankItem(item.detail as Tank, item.level);
	}
}
