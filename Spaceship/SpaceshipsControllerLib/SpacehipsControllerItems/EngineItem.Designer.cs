namespace SpaceshipsControllerLib.SpacehipsControllerItems
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
			components = new System.ComponentModel.Container();
			this.forceController = new System.Windows.Forms.TrackBar();
			this.directionController = new SpaceshipsControllerLib.DirectionController();
			this.mfLabel = new System.Windows.Forms.Label();
			// 
			// forceController
			// 
			this.forceController.Location = new System.Drawing.Point(170, 3);
			this.forceController.Maximum = 100;
			this.forceController.Name = "forceController";
			this.forceController.Size = new System.Drawing.Size(75, 56);
			this.forceController.TabIndex = 11;
			this.forceController.TickFrequency = 5;
			// 
			// directionController
			// 
			this.directionController.BackColor = System.Drawing.Color.Transparent;
			this.directionController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.directionController.Location = new System.Drawing.Point(276, 3);
			this.directionController.Name = "directionController";
			this.directionController.Height = this.forceController.Height;
			this.directionController.Width = this.forceController.Height;
			this.directionController.TabIndex = 13;
			// 
			// mfLabel
			// 
			this.mfLabel.Location = new System.Drawing.Point(398, 8);
			this.mfLabel.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.mfLabel.Name = "mfLabel";
			this.mfLabel.AutoSize = false;
			this.mfLabel.Size = new System.Drawing.Size(60, 17);
			this.mfLabel.TabIndex = 12;
			this.mfLabel.Text = "Max force: ";
			this.mfLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mfLabel.Height = this.forceController.Height;
			//
			// layotFloawPanel
			//
			this.layoutFlowPanel.Controls.Add(this.mfLabel);
			this.layoutFlowPanel.Controls.Add(this.forceController);
			this.layoutFlowPanel.Controls.Add(this.directionController);
			//
			// titleLabel
			//
			this.titleLabel.AutoSize = false;
			this.titleLabel.Height = this.forceController.Height;
			//
			// detachButton
			//
			this.detachButton.AutoSize = false;
			this.detachButton.Height = this.forceController.Height;
			this.detachButton.Width += 5;
			//
			// massLabel
			//
			this.massLabel.AutoSize = false;
			this.massLabel.Height = this.forceController.Height;
			// 
			// panelTabulation
			// 
			this.panelTabulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panelTabulation.Height = this.forceController.Height;
		}

		#endregion
		private System.Windows.Forms.TrackBar forceController;
		private System.Windows.Forms.Label mfLabel;
		private DirectionController directionController;
	}
}
