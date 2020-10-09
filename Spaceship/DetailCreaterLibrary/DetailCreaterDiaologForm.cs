using System;
using System.Drawing;
using System.Windows.Forms;

using SpaceshipModel;

namespace DetailCreaterLibrary
{
	internal partial class DetailCreaterDiaologForm : Form
	{
		private Type type;
		private Bitmap look;
		public Detail Detail { get; private set; }

		public DetailCreaterDiaologForm(Type type, Bitmap look)
		{
			InitializeComponent();
			this.type = type;
			this.look = look;
			if (type == typeof(Engine))
			{
				MFMTFLabel.Text += "max force:";
				MFMTFLabel.Visible = true;
				MFMTFTextBox.Visible = true;
			}
			else if (type == typeof(Tank))
			{
				MFMTFLabel.Text += "mass to force transforming coef:";
				MFMTFLabel.Visible = true;
				MFMTFTextBox.Visible = true;
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(massTextBox.Text.Replace('.', ','), out decimal mass))
			{
				if (type == typeof(Engine))
				{
					if (decimal.TryParse(MFMTFTextBox.Text.Replace('.', ','), out decimal maxForce))
					{
						Detail = new Engine(look, mass, maxForce);
						Close();
					}
					else
						MessageBox.Show("Enter max force in Neutons, by digits.");
				}
				else if (type == typeof(Tank))
				{
					if (decimal.TryParse(MFMTFTextBox.Text.Replace('.', ','), out decimal MTFcoef))
					{
						Detail = new Tank(look, mass, MTFcoef);
						Close();
					}
					else
						MessageBox.Show("Enter mass to force transforming coef, by digits.");
				}
				else if (type == typeof(Detail))
				{
					Detail = new Detail(look, mass);
					Close();
				}
			}
			else
				MessageBox.Show("Enter mass in kilograms, by digits.");
		}
	}
}
