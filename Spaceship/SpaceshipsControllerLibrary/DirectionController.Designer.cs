namespace SpaceshipsControllerLibrary
{
	partial class DirectionController
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
			this.controllerPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.controllerPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// controllerPictureBox
			// 
			this.controllerPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.controllerPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controllerPictureBox.Location = new System.Drawing.Point(0, 0);
			this.controllerPictureBox.Name = "controllerPictureBox";
			this.controllerPictureBox.Size = new System.Drawing.Size(58, 56);
			this.controllerPictureBox.TabIndex = 0;
			this.controllerPictureBox.TabStop = false;
			this.controllerPictureBox.SizeChanged += new System.EventHandler(this.controllerPictureBox_SizeChanged);
			this.controllerPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controllerPictureBox_MouseDown);
			this.controllerPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controllerPictureBox_MouseMove);
			this.controllerPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controllerPictureBox_MouseUp);
			// 
			// DirectionController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Controls.Add(this.controllerPictureBox);
			this.Name = "DirectionController";
			this.Size = new System.Drawing.Size(58, 56);
			this.MouseLeave += new System.EventHandler(this.DirectionController_MouseLeave);
			((System.ComponentModel.ISupportInitialize)(this.controllerPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox controllerPictureBox;
	}
}
