namespace DetailCreaterLibrary
{
	partial class TankDiaologForm
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
			this.minMassLabel = new System.Windows.Forms.Label();
			this.mtfLabel = new System.Windows.Forms.Label();
			this.minMassBox = new System.Windows.Forms.NumericUpDown();
			this.mtfBox = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.minMassBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mtfBox)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(12, 106);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(162, 33);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// minMassLabel
			// 
			this.minMassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.minMassLabel.AutoSize = true;
			this.minMassLabel.BackColor = System.Drawing.Color.Transparent;
			this.minMassLabel.Location = new System.Drawing.Point(12, 9);
			this.minMassLabel.Name = "minMassLabel";
			this.minMassLabel.Size = new System.Drawing.Size(113, 17);
			this.minMassLabel.TabIndex = 4;
			this.minMassLabel.Text = "Enter min mass: ";
			// 
			// mtfLabel
			// 
			this.mtfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mtfLabel.AutoSize = true;
			this.mtfLabel.BackColor = System.Drawing.Color.Transparent;
			this.mtfLabel.Location = new System.Drawing.Point(12, 58);
			this.mtfLabel.Name = "mtfLabel";
			this.mtfLabel.Size = new System.Drawing.Size(166, 17);
			this.mtfLabel.TabIndex = 6;
			this.mtfLabel.Text = "Enter mass to force coef:";
			// 
			// minMassBox
			// 
			this.minMassBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.minMassBox.DecimalPlaces = 5;
			this.minMassBox.Location = new System.Drawing.Point(12, 29);
			this.minMassBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.minMassBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
			this.minMassBox.Name = "minMassBox";
			this.minMassBox.Size = new System.Drawing.Size(162, 22);
			this.minMassBox.TabIndex = 10;
			this.minMassBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// mtfBox
			// 
			this.mtfBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mtfBox.DecimalPlaces = 7;
			this.mtfBox.Location = new System.Drawing.Point(12, 78);
			this.mtfBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.mtfBox.Name = "mtfBox";
			this.mtfBox.Size = new System.Drawing.Size(162, 22);
			this.mtfBox.TabIndex = 11;
			// 
			// TankDiaologForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(186, 152);
			this.Controls.Add(this.mtfBox);
			this.Controls.Add(this.minMassBox);
			this.Controls.Add(this.mtfLabel);
			this.Controls.Add(this.minMassLabel);
			this.Controls.Add(this.saveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MinimumSize = new System.Drawing.Size(204, 199);
			this.Name = "TankDiaologForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tank parametrs";
			((System.ComponentModel.ISupportInitialize)(this.minMassBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mtfBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label minMassLabel;
		private System.Windows.Forms.Label mtfLabel;
		public System.Windows.Forms.NumericUpDown minMassBox;
		public System.Windows.Forms.NumericUpDown mtfBox;
	}
}