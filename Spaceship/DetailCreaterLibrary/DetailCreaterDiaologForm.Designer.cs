namespace DetailCreaterLibrary
{
	partial class DetailCreaterDiaologForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.saveButton = new System.Windows.Forms.Button();
			this.massLabel = new System.Windows.Forms.Label();
			this.massTextBox = new System.Windows.Forms.TextBox();
			this.MFMTFTextBox = new System.Windows.Forms.TextBox();
			this.MFMTFLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(12, 106);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(137, 33);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// massLabel
			// 
			this.massLabel.AutoSize = true;
			this.massLabel.BackColor = System.Drawing.Color.Transparent;
			this.massLabel.Location = new System.Drawing.Point(12, 9);
			this.massLabel.Name = "massLabel";
			this.massLabel.Size = new System.Drawing.Size(83, 17);
			this.massLabel.TabIndex = 4;
			this.massLabel.Text = "Enter mass:";
			// 
			// massTextBox
			// 
			this.massTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.massTextBox.Location = new System.Drawing.Point(12, 29);
			this.massTextBox.Name = "massTextBox";
			this.massTextBox.Size = new System.Drawing.Size(137, 22);
			this.massTextBox.TabIndex = 5;
			// 
			// MFMTFTextBox
			// 
			this.MFMTFTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MFMTFTextBox.Location = new System.Drawing.Point(12, 74);
			this.MFMTFTextBox.Name = "MFMTFTextBox";
			this.MFMTFTextBox.Size = new System.Drawing.Size(137, 22);
			this.MFMTFTextBox.TabIndex = 7;
			this.MFMTFTextBox.Visible = false;
			// 
			// MFMTFLabel
			// 
			this.MFMTFLabel.AutoSize = true;
			this.MFMTFLabel.BackColor = System.Drawing.Color.Transparent;
			this.MFMTFLabel.Location = new System.Drawing.Point(12, 54);
			this.MFMTFLabel.Name = "MFMTFLabel";
			this.MFMTFLabel.Size = new System.Drawing.Size(46, 17);
			this.MFMTFLabel.TabIndex = 6;
			this.MFMTFLabel.Text = "Enter ";
			this.MFMTFLabel.Visible = false;
			// 
			// DetailCreaterDiaologForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(161, 152);
			this.Controls.Add(this.MFMTFTextBox);
			this.Controls.Add(this.MFMTFLabel);
			this.Controls.Add(this.massTextBox);
			this.Controls.Add(this.massLabel);
			this.Controls.Add(this.saveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MinimumSize = new System.Drawing.Size(18, 92);
			this.Name = "DetailCreaterDiaologForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input parametrs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label massLabel;
		private System.Windows.Forms.TextBox massTextBox;
		private System.Windows.Forms.TextBox MFMTFTextBox;
		private System.Windows.Forms.Label MFMTFLabel;
	}
}