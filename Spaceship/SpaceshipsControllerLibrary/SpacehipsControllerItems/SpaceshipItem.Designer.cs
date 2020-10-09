namespace SpaceshipsControllerLibrary.SpacehipsControllerItems
{
	partial class SpaceshipItem
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
			this.titleLabel = new System.Windows.Forms.Label();
			this.editCheckBox = new System.Windows.Forms.CheckBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.layoutFlowPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutFlowPanel
			// 
			this.layoutFlowPanel.AutoSize = true;
			this.layoutFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.layoutFlowPanel.Controls.Add(this.titleLabel);
			this.layoutFlowPanel.Controls.Add(this.editCheckBox);
			this.layoutFlowPanel.Controls.Add(this.deleteButton);
			this.layoutFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutFlowPanel.Location = new System.Drawing.Point(0, 0);
			this.layoutFlowPanel.Name = "layoutFlowPanel";
			this.layoutFlowPanel.Size = new System.Drawing.Size(225, 33);
			this.layoutFlowPanel.TabIndex = 0;
			this.layoutFlowPanel.WrapContents = false;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Location = new System.Drawing.Point(8, 8);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(8);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(78, 17);
			this.titleLabel.TabIndex = 7;
			this.titleLabel.Text = "Spaceship ";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// editCheckBox
			// 
			this.editCheckBox.AutoSize = true;
			this.editCheckBox.Location = new System.Drawing.Point(100, 6);
			this.editCheckBox.Margin = new System.Windows.Forms.Padding(6);
			this.editCheckBox.Name = "editCheckBox";
			this.editCheckBox.Size = new System.Drawing.Size(54, 21);
			this.editCheckBox.TabIndex = 10;
			this.editCheckBox.Text = "Edit";
			this.editCheckBox.UseVisualStyleBackColor = true;
			// 
			// deleteButton
			// 
			this.deleteButton.AutoSize = true;
			this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.deleteButton.Location = new System.Drawing.Point(163, 3);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(59, 27);
			this.deleteButton.TabIndex = 8;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// SpaceshipItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutFlowPanel);
			this.Name = "SpaceshipItem";
			this.Size = new System.Drawing.Size(225, 33);
			this.layoutFlowPanel.ResumeLayout(false);
			this.layoutFlowPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel layoutFlowPanel;
		private System.Windows.Forms.Label titleLabel;
		public System.Windows.Forms.Button deleteButton;
		public System.Windows.Forms.CheckBox editCheckBox;
	}
}
