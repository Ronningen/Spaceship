namespace SpaceLib
{
    partial class Space
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
			this.components = new System.ComponentModel.Container();
			this.spaceGroupBox = new System.Windows.Forms.GroupBox();
			this.spacePictureBox = new System.Windows.Forms.PictureBox();
			this.worldTimer = new System.Windows.Forms.Timer(this.components);
			this.spaceGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spacePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// spaceGroupBox
			// 
			this.spaceGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.spaceGroupBox.Controls.Add(this.spacePictureBox);
			this.spaceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spaceGroupBox.Location = new System.Drawing.Point(0, 0);
			this.spaceGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.spaceGroupBox.Name = "spaceGroupBox";
			this.spaceGroupBox.Padding = new System.Windows.Forms.Padding(6);
			this.spaceGroupBox.Size = new System.Drawing.Size(36, 54);
			this.spaceGroupBox.TabIndex = 4;
			this.spaceGroupBox.TabStop = false;
			this.spaceGroupBox.Text = "Space";
			// 
			// spacePictureBox
			// 
			this.spacePictureBox.BackColor = System.Drawing.Color.Silver;
			this.spacePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spacePictureBox.Location = new System.Drawing.Point(6, 21);
			this.spacePictureBox.Name = "spacePictureBox";
			this.spacePictureBox.Size = new System.Drawing.Size(24, 27);
			this.spacePictureBox.TabIndex = 1;
			this.spacePictureBox.TabStop = false;
			this.spacePictureBox.SizeChanged += new System.EventHandler(this.spacePictureBox_SizeChanged);
			// 
			// worldTimer
			// 
			this.worldTimer.Enabled = true;
			this.worldTimer.Interval = 33;
			this.worldTimer.Tick += new System.EventHandler(this.worldTimer_Tick);
			// 
			// Space
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.spaceGroupBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(36, 54);
			this.Name = "Space";
			this.Size = new System.Drawing.Size(36, 54);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Space_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Space_DragEnter);
			this.spaceGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spacePictureBox)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox spaceGroupBox;
		public System.Windows.Forms.PictureBox spacePictureBox;
		private System.Windows.Forms.Timer worldTimer;
	}
}
