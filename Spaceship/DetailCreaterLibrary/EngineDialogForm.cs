using System.Windows.Forms;

namespace DetailCreatorLib
{
	public partial class EngineDialogForm : Form
	{
		public EngineDialogForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
