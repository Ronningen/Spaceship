namespace SpaceshipsControllerLib
{
    partial class SpaceshipsController
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
			this.layoutGroupBox = new System.Windows.Forms.GroupBox();
			this.layoutFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.layoutGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutGroupBox
			// 
			this.layoutGroupBox.Controls.Add(this.layoutFlowPanel);
			this.layoutGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutGroupBox.Location = new System.Drawing.Point(0, 0);
			this.layoutGroupBox.Name = "layoutGroupBox";
			this.layoutGroupBox.Size = new System.Drawing.Size(145, 96);
			this.layoutGroupBox.TabIndex = 0;
			this.layoutGroupBox.TabStop = false;
			this.layoutGroupBox.Text = "Spaceships controller";
			// 
			// layoutFlowPanel
			// 
			this.layoutFlowPanel.AutoScroll = true;
			this.layoutFlowPanel.AutoSize = true;
			this.layoutFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.layoutFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.layoutFlowPanel.Location = new System.Drawing.Point(3, 18);
			this.layoutFlowPanel.Name = "layoutFlowPanel";
			this.layoutFlowPanel.Size = new System.Drawing.Size(139, 75);
			this.layoutFlowPanel.TabIndex = 0;
			this.layoutFlowPanel.WrapContents = false;
			// 
			// SpaceshipsController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutGroupBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "SpaceshipsController";
			this.Size = new System.Drawing.Size(145, 96);
			this.layoutGroupBox.ResumeLayout(false);
			this.layoutGroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox layoutGroupBox;
		private System.Windows.Forms.FlowLayoutPanel layoutFlowPanel;
	}
}
