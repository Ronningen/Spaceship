using System.Windows.Forms;

namespace Spaceship
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			detailCreater.DetailSaved += detailsList.GetNewDetail;
			spaceshipsController.SetWorld(space.world);
			space.DetailAttached += spaceshipsController.UpdateList;
		}
	}
}
