namespace DetailCreatorLib
{
    partial class DetailCreator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.canvasPictureBox = new System.Windows.Forms.PictureBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.typeLabel = new System.Windows.Forms.Label();
			this.helpButton = new System.Windows.Forms.Button();
			this.layoutGroupBox = new System.Windows.Forms.GroupBox();
			this.massBox = new System.Windows.Forms.NumericUpDown();
			this.massLabel = new System.Windows.Forms.Label();
			this.widthBox = new System.Windows.Forms.NumericUpDown();
			this.widthLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).BeginInit();
			this.layoutGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.massBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
			this.SuspendLayout();
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(6, 41);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(157, 24);
			this.typeComboBox.TabIndex = 0;
			this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
			// 
			// canvasPictureBox
			// 
			this.canvasPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.canvasPictureBox.BackColor = System.Drawing.Color.White;
			this.canvasPictureBox.Location = new System.Drawing.Point(6, 99);
			this.canvasPictureBox.Name = "canvasPictureBox";
			this.canvasPictureBox.Size = new System.Drawing.Size(157, 60);
			this.canvasPictureBox.TabIndex = 1;
			this.canvasPictureBox.TabStop = false;
			this.canvasPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPictureBox_MouseDown);
			this.canvasPictureBox.MouseLeave += new System.EventHandler(this.canvasPictureBox_MouseLeave);
			this.canvasPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPictureBox_MouseMove);
			this.canvasPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPictureBox_MouseUp);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(6, 193);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(157, 34);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(6, 18);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(129, 17);
			this.typeLabel.TabIndex = 3;
			this.typeLabel.Text = "Сhoose detail type:";
			// 
			// helpButton
			// 
			this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.helpButton.Location = new System.Drawing.Point(139, 10);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(24, 25);
			this.helpButton.TabIndex = 4;
			this.helpButton.Text = "?";
			this.helpButton.UseVisualStyleBackColor = true;
			this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// layoutGroupBox
			// 
			this.layoutGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.layoutGroupBox.Controls.Add(this.massBox);
			this.layoutGroupBox.Controls.Add(this.massLabel);
			this.layoutGroupBox.Controls.Add(this.widthBox);
			this.layoutGroupBox.Controls.Add(this.widthLabel);
			this.layoutGroupBox.Controls.Add(this.typeLabel);
			this.layoutGroupBox.Controls.Add(this.helpButton);
			this.layoutGroupBox.Controls.Add(this.saveButton);
			this.layoutGroupBox.Controls.Add(this.typeComboBox);
			this.layoutGroupBox.Controls.Add(this.canvasPictureBox);
			this.layoutGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutGroupBox.Location = new System.Drawing.Point(0, 0);
			this.layoutGroupBox.MinimumSize = new System.Drawing.Size(169, 188);
			this.layoutGroupBox.Name = "layoutGroupBox";
			this.layoutGroupBox.Size = new System.Drawing.Size(169, 233);
			this.layoutGroupBox.TabIndex = 7;
			this.layoutGroupBox.TabStop = false;
			this.layoutGroupBox.Text = "Detail creator";
			// 
			// massBox
			// 
			this.massBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.massBox.DecimalPlaces = 5;
			this.massBox.Location = new System.Drawing.Point(57, 165);
			this.massBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.massBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
			this.massBox.Name = "massBox";
			this.massBox.Size = new System.Drawing.Size(106, 22);
			this.massBox.TabIndex = 9;
			this.massBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// massLabel
			// 
			this.massLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.massLabel.AutoSize = true;
			this.massLabel.BackColor = System.Drawing.Color.Transparent;
			this.massLabel.Location = new System.Drawing.Point(6, 168);
			this.massLabel.Name = "massLabel";
			this.massLabel.Size = new System.Drawing.Size(45, 17);
			this.massLabel.TabIndex = 7;
			this.massLabel.Text = "Mass:";
			// 
			// widthBox
			// 
			this.widthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.widthBox.Location = new System.Drawing.Point(97, 71);
			this.widthBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.widthBox.Name = "widthBox";
			this.widthBox.Size = new System.Drawing.Size(66, 22);
			this.widthBox.TabIndex = 6;
			this.widthBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			// 
			// widthLabel
			// 
			this.widthLabel.AutoSize = true;
			this.widthLabel.Location = new System.Drawing.Point(6, 73);
			this.widthLabel.Name = "widthLabel";
			this.widthLabel.Size = new System.Drawing.Size(85, 17);
			this.widthLabel.TabIndex = 5;
			this.widthLabel.Text = "Brush width:";
			// 
			// DetailCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutGroupBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(167, 150);
			this.Name = "DetailCreator";
			this.Size = new System.Drawing.Size(167, 233);
			this.SizeChanged += new System.EventHandler(this.DetailCreater_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.canvasPictureBox)).EndInit();
			this.layoutGroupBox.ResumeLayout(false);
			this.layoutGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.massBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.PictureBox canvasPictureBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.GroupBox layoutGroupBox;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.NumericUpDown widthBox;
		private System.Windows.Forms.NumericUpDown massBox;
		private System.Windows.Forms.Label massLabel;
	}
}
