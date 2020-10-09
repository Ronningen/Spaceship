namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	partial class EngineItem
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
			this.layoutFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panelTabulation = new System.Windows.Forms.Panel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.detachButton = new System.Windows.Forms.Button();
			this.forceController = new System.Windows.Forms.TrackBar();
			this.directionController = new SpaceshipsControllerLibrary.DirectionController();
			this.massLabel = new System.Windows.Forms.Label();
			this.mfLabel = new System.Windows.Forms.Label();
			this.layoutFlowPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.forceController)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutFlowPanel
			// 
			this.layoutFlowPanel.AutoSize = true;
			this.layoutFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.layoutFlowPanel.BackColor = System.Drawing.Color.Transparent;
			this.layoutFlowPanel.Controls.Add(this.panelTabulation);
			this.layoutFlowPanel.Controls.Add(this.titleLabel);
			this.layoutFlowPanel.Controls.Add(this.detachButton);
			this.layoutFlowPanel.Controls.Add(this.forceController);
			this.layoutFlowPanel.Controls.Add(this.directionController);
			this.layoutFlowPanel.Controls.Add(this.massLabel);
			this.layoutFlowPanel.Controls.Add(this.mfLabel);
			this.layoutFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutFlowPanel.Location = new System.Drawing.Point(0, 0);
			this.layoutFlowPanel.Name = "layoutFlowPanel";
			this.layoutFlowPanel.Size = new System.Drawing.Size(480, 62);
			this.layoutFlowPanel.TabIndex = 2;
			this.layoutFlowPanel.WrapContents = false;
			// 
			// panelTabulation
			// 
			this.panelTabulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panelTabulation.Location = new System.Drawing.Point(3, 3);
			this.panelTabulation.Name = "panelTabulation";
			this.panelTabulation.Size = new System.Drawing.Size(20, 56);
			this.panelTabulation.TabIndex = 10;
			// 
			// titleLabel
			// 
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Location = new System.Drawing.Point(28, 8);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(56, 46);
			this.titleLabel.TabIndex = 7;
			this.titleLabel.Text = "Engine ";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// detachButton
			// 
			this.detachButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.detachButton.Location = new System.Drawing.Point(89, 3);
			this.detachButton.Name = "detachButton";
			this.detachButton.Size = new System.Drawing.Size(75, 56);
			this.detachButton.TabIndex = 8;
			this.detachButton.Text = "Detach";
			this.detachButton.UseVisualStyleBackColor = true;
			// 
			// forceController
			// 
			this.forceController.Location = new System.Drawing.Point(170, 3);
			this.forceController.Maximum = 100;
			this.forceController.Name = "forceController";
			this.forceController.Size = new System.Drawing.Size(100, 56);
			this.forceController.TabIndex = 11;
			this.forceController.TickFrequency = 5;
			// 
			// directionController
			// 
			this.directionController.BackColor = System.Drawing.Color.Transparent;
			this.directionController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.directionController.Location = new System.Drawing.Point(276, 3);
			this.directionController.Name = "directionController";
			this.directionController.Size = new System.Drawing.Size(58, 56);
			this.directionController.TabIndex = 13;
			// 
			// massLabel
			// 
			this.massLabel.Location = new System.Drawing.Point(339, 8);
			this.massLabel.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
			this.massLabel.Name = "massLabel";
			this.massLabel.Size = new System.Drawing.Size(49, 46);
			this.massLabel.TabIndex = 14;
			this.massLabel.Text = "Mass: ";
			this.massLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mfLabel
			// 
			this.mfLabel.Location = new System.Drawing.Point(398, 8);
			this.mfLabel.Margin = new System.Windows.Forms.Padding(2, 8, 8, 8);
			this.mfLabel.Name = "mfLabel";
			this.mfLabel.Size = new System.Drawing.Size(74, 46);
			this.mfLabel.TabIndex = 12;
			this.mfLabel.Text = "Max force: ";
			this.mfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EngineItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutFlowPanel);
			this.Name = "EngineItem";
			this.Size = new System.Drawing.Size(480, 62);
			this.layoutFlowPanel.ResumeLayout(false);
			this.layoutFlowPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.forceController)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelTabulation;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.FlowLayoutPanel layoutFlowPanel;
		private System.Windows.Forms.TrackBar forceController;
		public System.Windows.Forms.Button detachButton;
		private System.Windows.Forms.Label mfLabel;
		private DirectionController directionController;
		private System.Windows.Forms.Label massLabel;
	}
}
