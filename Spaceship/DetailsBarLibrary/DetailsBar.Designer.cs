namespace DetailsBarLibrary
{
	partial class DetailsBar
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
			this.detailsListView = new System.Windows.Forms.ListView();
			this.deleteButton = new System.Windows.Forms.Button();
			this.layoutGroupBox = new System.Windows.Forms.GroupBox();
			this.layoutGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// detailsListView
			// 
			this.detailsListView.BackColor = System.Drawing.Color.Silver;
			this.detailsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.detailsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailsListView.ForeColor = System.Drawing.Color.Black;
			this.detailsListView.HideSelection = false;
			this.detailsListView.Location = new System.Drawing.Point(6, 21);
			this.detailsListView.Name = "detailsListView";
			this.detailsListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.detailsListView.Size = new System.Drawing.Size(191, 82);
			this.detailsListView.TabIndex = 0;
			this.detailsListView.UseCompatibleStateImageBehavior = false;
			this.detailsListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemCollection_MouseMove);
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.AutoSize = true;
			this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.deleteButton.Location = new System.Drawing.Point(130, 25);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(63, 26);
			this.deleteButton.TabIndex = 1;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.Delete_Click);
			// 
			// layoutGroupBox
			// 
			this.layoutGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.layoutGroupBox.Controls.Add(this.deleteButton);
			this.layoutGroupBox.Controls.Add(this.detailsListView);
			this.layoutGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutGroupBox.Location = new System.Drawing.Point(0, 0);
			this.layoutGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.layoutGroupBox.Name = "layoutGroupBox";
			this.layoutGroupBox.Padding = new System.Windows.Forms.Padding(6);
			this.layoutGroupBox.Size = new System.Drawing.Size(203, 109);
			this.layoutGroupBox.TabIndex = 3;
			this.layoutGroupBox.TabStop = false;
			this.layoutGroupBox.Text = "Details bar";
			// 
			// DetailsBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.layoutGroupBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "DetailsBar";
			this.Size = new System.Drawing.Size(203, 109);
			this.layoutGroupBox.ResumeLayout(false);
			this.layoutGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView detailsListView;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.GroupBox layoutGroupBox;
	}
}
