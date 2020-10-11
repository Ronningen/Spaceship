namespace SpaceshipsControllerLib.SpacehipsControllerItems
{
	partial class TankItem
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
			this.mtfLabel = new System.Windows.Forms.Label();
			//
			// layotFloawPanel
			//
			this.layoutFlowPanel.Controls.Add(this.mtfLabel);
			// 
			// panelTabulation
			// 
			this.panelTabulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			// 
			// mtfLabel
			// 
			this.mtfLabel.AutoSize = true;
			this.mtfLabel.Location = new System.Drawing.Point(210, 8);
			this.mtfLabel.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.mtfLabel.Name = "mtfLabel";
			this.mtfLabel.AutoSize = false;
			this.mtfLabel.Size = new System.Drawing.Size(35, 17);
			this.mtfLabel.TabIndex = 13;
			this.mtfLabel.Text = "mtf: ";
			this.mtfLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		}

		#endregion
		private System.Windows.Forms.Label mtfLabel;
	}
}
