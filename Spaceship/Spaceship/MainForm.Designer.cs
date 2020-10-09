namespace Spaceship
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.detailsList = new DetailsBarLibrary.DetailsBar();
			this.spaceSplitter = new System.Windows.Forms.SplitContainer();
			this.detailCreaterSplitter = new System.Windows.Forms.SplitContainer();
			this.detailCreater = new DetailCreaterLibrary.DetailCreater();
			this.space = new SpaceLibrary.Space();
			this.spaceshipsController = new SpaceshipsControllerLibrary.SpaceshipsController();
			this.controllerSplitter = new System.Windows.Forms.SplitContainer();
			this.barSplitter = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.spaceSplitter)).BeginInit();
			this.spaceSplitter.Panel1.SuspendLayout();
			this.spaceSplitter.Panel2.SuspendLayout();
			this.spaceSplitter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.detailCreaterSplitter)).BeginInit();
			this.detailCreaterSplitter.Panel1.SuspendLayout();
			this.detailCreaterSplitter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.controllerSplitter)).BeginInit();
			this.controllerSplitter.Panel1.SuspendLayout();
			this.controllerSplitter.Panel2.SuspendLayout();
			this.controllerSplitter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.barSplitter)).BeginInit();
			this.barSplitter.Panel1.SuspendLayout();
			this.barSplitter.Panel2.SuspendLayout();
			this.barSplitter.SuspendLayout();
			this.SuspendLayout();
			// 
			// detailsList
			// 
			this.detailsList.BackColor = System.Drawing.Color.Transparent;
			this.detailsList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailsList.Location = new System.Drawing.Point(0, 0);
			this.detailsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.detailsList.Name = "detailsList";
			this.detailsList.Size = new System.Drawing.Size(613, 88);
			this.detailsList.TabIndex = 4;
			// 
			// spaceSplitter
			// 
			this.spaceSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spaceSplitter.Location = new System.Drawing.Point(0, 0);
			this.spaceSplitter.Margin = new System.Windows.Forms.Padding(0);
			this.spaceSplitter.Name = "spaceSplitter";
			// 
			// spaceSplitter.Panel1
			// 
			this.spaceSplitter.Panel1.Controls.Add(this.detailCreaterSplitter);
			// 
			// spaceSplitter.Panel2
			// 
			this.spaceSplitter.Panel2.Controls.Add(this.space);
			this.spaceSplitter.Size = new System.Drawing.Size(613, 448);
			this.spaceSplitter.SplitterDistance = 162;
			this.spaceSplitter.TabIndex = 6;
			// 
			// detailCreaterSplitter
			// 
			this.detailCreaterSplitter.BackColor = System.Drawing.Color.Transparent;
			this.detailCreaterSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailCreaterSplitter.Location = new System.Drawing.Point(0, 0);
			this.detailCreaterSplitter.Margin = new System.Windows.Forms.Padding(0);
			this.detailCreaterSplitter.Name = "detailCreaterSplitter";
			this.detailCreaterSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// detailCreaterSplitter.Panel1
			// 
			this.detailCreaterSplitter.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.detailCreaterSplitter.Panel1.Controls.Add(this.detailCreater);
			this.detailCreaterSplitter.Panel1MinSize = 0;
			// 
			// detailCreaterSplitter.Panel2
			// 
			this.detailCreaterSplitter.Panel2.BackColor = System.Drawing.Color.Transparent;
			this.detailCreaterSplitter.Size = new System.Drawing.Size(162, 448);
			this.detailCreaterSplitter.SplitterDistance = 306;
			this.detailCreaterSplitter.TabIndex = 7;
			// 
			// detailCreater
			// 
			this.detailCreater.BackColor = System.Drawing.Color.White;
			this.detailCreater.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailCreater.Location = new System.Drawing.Point(0, 0);
			this.detailCreater.Margin = new System.Windows.Forms.Padding(2);
			this.detailCreater.MinimumSize = new System.Drawing.Size(167, 150);
			this.detailCreater.Name = "detailCreater";
			this.detailCreater.Size = new System.Drawing.Size(167, 306);
			this.detailCreater.TabIndex = 0;
			// 
			// space
			// 
			this.space.AllowDrop = true;
			this.space.BackColor = System.Drawing.Color.Transparent;
			this.space.Dock = System.Windows.Forms.DockStyle.Fill;
			this.space.Location = new System.Drawing.Point(0, 0);
			this.space.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.space.MinimumSize = new System.Drawing.Size(36, 54);
			this.space.Name = "space";
			this.space.Size = new System.Drawing.Size(447, 448);
			this.space.TabIndex = 5;
			// 
			// spaceshipsController
			// 
			this.spaceshipsController.BackColor = System.Drawing.Color.Transparent;
			this.spaceshipsController.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spaceshipsController.Location = new System.Drawing.Point(0, 0);
			this.spaceshipsController.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.spaceshipsController.Name = "spaceshipsController";
			this.spaceshipsController.Size = new System.Drawing.Size(211, 540);
			this.spaceshipsController.TabIndex = 2;
			// 
			// controllerSplitter
			// 
			this.controllerSplitter.BackColor = System.Drawing.Color.Transparent;
			this.controllerSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controllerSplitter.Location = new System.Drawing.Point(0, 0);
			this.controllerSplitter.Margin = new System.Windows.Forms.Padding(0);
			this.controllerSplitter.Name = "controllerSplitter";
			// 
			// controllerSplitter.Panel1
			// 
			this.controllerSplitter.Panel1.Controls.Add(this.barSplitter);
			// 
			// controllerSplitter.Panel2
			// 
			this.controllerSplitter.Panel2.Controls.Add(this.spaceshipsController);
			this.controllerSplitter.Size = new System.Drawing.Size(828, 540);
			this.controllerSplitter.SplitterDistance = 613;
			this.controllerSplitter.TabIndex = 7;
			// 
			// barSplitter
			// 
			this.barSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barSplitter.Location = new System.Drawing.Point(0, 0);
			this.barSplitter.Margin = new System.Windows.Forms.Padding(0);
			this.barSplitter.Name = "barSplitter";
			this.barSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// barSplitter.Panel1
			// 
			this.barSplitter.Panel1.Controls.Add(this.detailsList);
			// 
			// barSplitter.Panel2
			// 
			this.barSplitter.Panel2.Controls.Add(this.spaceSplitter);
			this.barSplitter.Size = new System.Drawing.Size(613, 540);
			this.barSplitter.SplitterDistance = 88;
			this.barSplitter.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(828, 540);
			this.Controls.Add(this.controllerSplitter);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spaceship simulator";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.spaceSplitter.Panel1.ResumeLayout(false);
			this.spaceSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spaceSplitter)).EndInit();
			this.spaceSplitter.ResumeLayout(false);
			this.detailCreaterSplitter.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.detailCreaterSplitter)).EndInit();
			this.detailCreaterSplitter.ResumeLayout(false);
			this.controllerSplitter.Panel1.ResumeLayout(false);
			this.controllerSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.controllerSplitter)).EndInit();
			this.controllerSplitter.ResumeLayout(false);
			this.barSplitter.Panel1.ResumeLayout(false);
			this.barSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.barSplitter)).EndInit();
			this.barSplitter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private SpaceshipsControllerLibrary.SpaceshipsController spaceshipsController;
		private DetailsBarLibrary.DetailsBar detailsList;
		private SpaceLibrary.Space space;
		private System.Windows.Forms.SplitContainer spaceSplitter;
		private System.Windows.Forms.SplitContainer detailCreaterSplitter;
		private DetailCreaterLibrary.DetailCreater detailCreater;
		private System.Windows.Forms.SplitContainer controllerSplitter;
		private System.Windows.Forms.SplitContainer barSplitter;
	}
}