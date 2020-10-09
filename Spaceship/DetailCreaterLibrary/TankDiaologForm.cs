using System.Windows.Forms;

namespace DetailCreaterLibrary
{
	internal partial class TankDiaologForm : Form
	{
		public TankDiaologForm()
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
