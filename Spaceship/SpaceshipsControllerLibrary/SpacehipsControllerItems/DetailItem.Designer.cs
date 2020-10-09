namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	partial class DetailItem
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
			this.massLabel = new System.Windows.Forms.Label();
			this.layoutFlowPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutFlowPanel
			// 
			this.layoutFlowPanel.AutoSize = true;
			this.layoutFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.layoutFlowPanel.BackColor = System.Drawing.Color.Transparent;
			this.layoutFlowPanel.Controls.Add(this.panelTabulation);
			this.layoutFlowPanel.Controls.Add(this.titleLabel);
			this.layoutFlowPanel.Controls.Add(this.massLabel);
			this.layoutFlowPanel.Controls.Add(this.detachButton);
			this.layoutFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutFlowPanel.Location = new System.Drawing.Point(0, 0);
			this.layoutFlowPanel.Name = "layoutFlowPanel";
			this.layoutFlowPanel.Size = new System.Drawing.Size(200, 33);
			this.layoutFlowPanel.TabIndex = 1;
			this.layoutFlowPanel.WrapContents = false;
			// 
			// panelTabulation
			// 
			this.panelTabulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panelTabulation.Location = new System.Drawing.Point(3, 3);
			this.panelTabulation.Name = "panelTabulation";
			this.panelTabulation.Size = new System.Drawing.Size(20, 27);
			this.panelTabulation.TabIndex = 10;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Location = new System.Drawing.Point(28, 8);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(48, 17);
			this.titleLabel.TabIndex = 7;
			this.titleLabel.Text = "Detail ";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// detachButton
			// 
			this.detachButton.AutoSize = true;
			this.detachButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.detachButton.Location = new System.Drawing.Point(134, 3);
			this.detachButton.Name = "detachButton";
			this.detachButton.Size = new System.Drawing.Size(63, 27);
			this.detachButton.TabIndex = 8;
			this.detachButton.Text = "Detach";
			this.detachButton.UseVisualStyleBackColor = true;
			// 
			// massLabel
			// 
			this.massLabel.AutoSize = true;
			this.massLabel.Location = new System.Drawing.Point(80, 8);
			this.massLabel.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
			this.massLabel.Name = "massLabel";
			this.massLabel.Size = new System.Drawing.Size(49, 17);
			this.massLabel.TabIndex = 11;
			this.massLabel.Text = "Mass: ";
			this.massLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DetailItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutFlowPanel);
			this.Name = "DetailItem";
			this.Size = new System.Drawing.Size(200, 33);
			this.layoutFlowPanel.ResumeLayout(false);
			this.layoutFlowPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		protected System.Windows.Forms.Label titleLabel;
		protected System.Windows.Forms.Panel panelTabulation;
		protected System.Windows.Forms.FlowLayoutPanel layoutFlowPanel;
		public System.Windows.Forms.Button detachButton;
		protected System.Windows.Forms.Label massLabel;
	}
}
