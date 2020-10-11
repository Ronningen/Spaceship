using System.Windows.Forms;

namespace DetailCreatorLib
{
	internal partial class TankDiaologForm : Form
	{
		public TankDiaologForm(decimal mass)
		{
			InitializeComponent();
			minMassBox.Maximum = mass;
		}

		private void saveButton_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
