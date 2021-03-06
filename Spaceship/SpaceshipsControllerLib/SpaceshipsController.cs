﻿using System.Linq;
using System.Windows.Forms;

using SpaceshipModelLib;

using SpaceshipsControllerLib.SpacehipsControllerItems;

namespace SpaceshipsControllerLib
{
	public partial class SpaceshipsController : UserControl
	{
		private World world;
		private int index;

		public SpaceshipsController()
		{
			InitializeComponent();
		}

		public void SetWorld(World world)
		{
			this.world = world;
			UpdateList();
		}

		public void UpdateList()
		{
			if (world != null)
			{
				layoutFlowPanel.Controls.Clear();
				index = 1;
				foreach (Spaceship spaceship in world.spaceships)
				{
					AddSpaceshipItem(spaceship);
					AddDetailItem(spaceship.Body, spaceship);
				}
			}
		}

		private void AddSpaceshipItem(Spaceship spaceship)
		{
			SpaceshipItem newItem = new SpaceshipItem(spaceship, ref index);
			newItem.editCheckBox.Checked = world.editingIndex == world.spaceships.IndexOf(spaceship);
			newItem.deleteButton.Click += (o, e) =>
			{
				world.spaceships.Remove(spaceship);
				if (world.spaceships.Count <= world.editingIndex)
					world.editingIndex = -1;
				UpdateList();
			};
			newItem.editCheckBox.Click += (o, e) =>
			{
				if (newItem.editCheckBox.Checked)
				{
					world.editingIndex = world.spaceships.IndexOf(spaceship);
					foreach (SpaceshipItem item in layoutFlowPanel.Controls.OfType<SpaceshipItem>())
						if (item != newItem)
							item.editCheckBox.Checked = false;
				}
				else
					world.editingIndex = -1;
			};
			layoutFlowPanel.Controls.Add(newItem);
		}

		private void AddDetailItem(Detail detail, Spaceship spaceship, int level = 1, bool isBody = true)
		{
			DetailItem newItem = new DetailItem(detail, level);
			if (detail is Engine engine)
				newItem = new EngineItem(engine, level);
			else if (detail is Tank tank)
				newItem = new TankItem(tank, level);
			newItem.detachButton.Click += (o, e) => { world.Detach(detail); UpdateList(); };
			if (isBody)
				newItem.detachButton.Dispose();
			layoutFlowPanel.Controls.Add(newItem);
			foreach (Detail child in detail.Children)
				AddDetailItem(child, spaceship, level + 1, false);
		}
	}
}
