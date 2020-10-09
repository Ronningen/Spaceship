﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using SpaceshipModel;

namespace DetailCreaterLibrary
{
	public partial class DetailCreater : UserControl
	{
		private Brush brush;
		private Dictionary<Type, Brush> brushes;
		private Type currentType;
		private Bitmap look;
		private Graphics g;

		public delegate void DetailHandler(Detail detail);
		public event DetailHandler DetailSaved;

		public DetailCreater()
		{
			InitializeComponent();
			brushes = new Dictionary<Type, Brush>();
			brushes.Add(typeof(Detail), Brushes.White);
			brushes.Add(typeof(Engine), Brushes.LightCoral);
			brushes.Add(typeof(Tank), Brushes.LightYellow);
			typeComboBox.Items.AddRange(brushes.Keys.Select(t => t.Name).ToArray());
			typeComboBox.SelectedIndex = 0;
		}

		private void UpdateCanvas()
		{
			look = new Bitmap(canvasPictureBox.Width, canvasPictureBox.Height);
			g = Graphics.FromImage(look);
			g.Clear(Color.Black);
			canvasPictureBox.Image = look;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (currentType != null && SomethingDrawed())
			{
				DetailCreaterDiaologForm dialog = new DetailCreaterDiaologForm(currentType, look);
				dialog.ShowDialog();
				if (dialog.Detail != null)
				{
					DetailSaved?.Invoke(dialog.Detail);
					UpdateCanvas();
				}
			}
			else
				MessageBox.Show("Choose detail type and draw a detail.");
		}

		private bool SomethingDrawed()
		{
			for (int x = 0; x < look.Width; x++)
				for (int y = 0; y < look.Height; y++)
					if (look.GetPixel(x, y) != Color.FromArgb(255, 0, 0, 0))
						return true;
			return false;
		}

		private void helpButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show(System.IO.File.ReadAllText("helpNote.txt"));
		}

		private void Draw(Point e)
		{
			if (brush != null)
			{
				int width = (int)widthBox.Value;
				g.FillEllipse(brush, e.X - width / 2, e.Y - width / 2, width, width);
				canvasPictureBox.Image = look;
			}
		}

		private void canvasPictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (currentType != null)
			{
				if (e.Button == MouseButtons.Left)
					brush = brushes[currentType];
				if (e.Button == MouseButtons.Right)
					brush = Brushes.Black;
			}
			else
				MessageBox.Show("Choose detail type.");
			Draw(e.Location);
		}

		private void canvasPictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			Draw(e.Location);
		}

		private void canvasPictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			brush = null;
		}

		private void canvasPictureBox_MouseLeave(object sender, EventArgs e)
		{
			brush = null;
		}

		private void DetailCreater_SizeChanged(object sender, EventArgs e)
		{
			canvasPictureBox.Width = typeComboBox.Width;
			UpdateCanvas();
		}

		private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (typeComboBox.SelectedItem is string s)
			{
				currentType = brushes.Keys.Where(t => t.Name == s).FirstOrDefault();
				UpdateCanvas();
			}
		}
	}
}