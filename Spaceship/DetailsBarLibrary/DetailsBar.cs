using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using SpaceshipModelLib;

namespace DetailsBarLib
{
	public partial class DetailsBar : UserControl
	{
		private List<Detail> details;
		public DetailsBar()
		{
			InitializeComponent();
			details = new List<Detail>();
			detailsListView.LargeImageList = new ImageList() { ImageSize = new Size(50, 50) };
		}

		public void GetNewDetail(Detail detail)
		{
			detail.type = SetDetailName(3);
			details.Add(detail);
			detailsListView.LargeImageList.Images.Add(detail.Look);
			ListViewItem viewDetails = new ListViewItem(detail.type, detailsListView.LargeImageList.Images.Count - 1);
			detailsListView.Items.Add(viewDetails);
		}

		private string SetDetailName(int x)
		{
			string detailName = "";
			Random r = new Random();
			while (detailName.Length < x)
			{
				char c = (char)r.Next(60, 125);
				if (char.IsLetter(c))
					detailName += c;
			}
			return detailName;
		}

		private void ItemCollection_MouseMove(object sender, MouseEventArgs e)
		{
			if (detailsListView.SelectedItems.Count > 0 && e.Button == MouseButtons.Left)
					foreach (ListViewItem item in detailsListView.SelectedItems)
						foreach (Detail detail in details)
							if (detail.type == item.Text)
								detailsListView.DoDragDrop(detail, DragDropEffects.Copy);
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem detail in detailsListView.SelectedItems)
				detailsListView.Items.Remove(detail);
		}
	}
}

