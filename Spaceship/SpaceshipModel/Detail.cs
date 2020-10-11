using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using SpaceshipModelLib.ShortMath;

namespace SpaceshipModelLib
{
	public class Detail
	{
		public string type;
		public uint number;
		/// <summary>
		/// Внешний вид детали
		/// </summary>
		public Bitmap Look { get; }
		public Vector CentreInLook { get; }

		protected decimal m;
		protected Vector centre;
		protected decimal j;

		public List<Detail> Children { get; private set; }
		/// <summary>
		/// Суммарная масса детали и дочерних детелей всех поколений.
		/// </summary>
		public decimal M { get; private set; }
		/// <summary>
		/// Центр масс детали и дочерних детелей всех поколений.
		/// </summary>
		public Vector Centre { get; private set; }
		/// <summary>
		/// Суммарный момент инерции относительно центра масс детали и дочерних детелей всех поколений.
		/// </summary>
		public decimal J { get; private set; }

		/// <summary>
		/// Обнавляет M, Centre, J
		/// </summary>
		public virtual void Update()
		{
			M = m;
			Centre = m * centre;
			foreach (Detail child in Children)
			{
				child.Update();
				M += child.M;
				Centre += child.M * child.Centre;
			}
			Centre /= M;
			J = j;
			foreach (Detail child in Children)
				J += child.J + child.M * (child.Centre - Centre).SquaredLength;
		}

		/// <summary>
		/// Проверяет, пересекаются ли эта деталь с деталью d.
		/// </summary>
		/// <returns></returns>
		private bool CanAttach(Detail detail)
		{
			Vector r = centre - CentreInLook;
			Vector rd = detail.centre - detail.CentreInLook;
			for (int x = 0; x < Look.Width; x++)
				for (int y = 0; y < Look.Height; y++)
					if (Look.GetPixel(x, y) != Color.FromArgb(0, 0, 0, 0))
					{
						Vector pixelInDetail = r - rd + (x, y);
						int curx = (int)pixelInDetail.X, cury = (int)pixelInDetail.Y;
						if (curx >=0 && curx < detail.Look.Width &&
							cury >= 0 && cury < detail.Look.Height &&
							detail.Look.GetPixel(curx, cury) != Color.FromArgb(0, 0, 0, 0))
							return true;
					}
			return false;
		}

		/// <summary>
		/// Прикрепляет новую деталь как дочернюю.
		/// </summary>
		/// <param name="detail"></param>
		public bool Attach(Detail detail)
		{
			if (CanAttach(detail))
			{
				Children.Add(detail);
				detail.number = (uint)Children.Where(c => c.type == detail.type).Count();
				return true;
			}
			foreach (Detail child in Children)
				if (child.Attach(detail))
					return true;
			return false;
		}

		/// <summary>
		/// Открепляет детали.
		/// </summary>
		/// <param name="detail"></param>
		public bool Detach(Detail detail)
		{
			if (Children.Remove(detail))
				return true;
			foreach (Detail child in Children)
				if (child.Detach(detail))
					return true;
			return false;
		}

		/// <summary>
		/// Собирает список дочерних двигателей.
		/// </summary>
		/// <param name="engines"></param>
		/// <returns></returns>
		public List<Engine> AggregateEngines(bool toTank = false)
		{
			List<Engine> engines = new List<Engine>();
			_AggregateEngines(engines, toTank);
			return engines;
		}
		private void _AggregateEngines(List<Engine> engines, bool toTank)
		{
			if (this is Engine engine)
				engines.Add(engine);
			foreach (Detail child in Children)
				if (!toTank || child.GetType() != typeof(Tank) || child.m <= 0)
					child._AggregateEngines(engines, toTank);
		}

		public virtual void Show(Graphics g)
		{
			g.DrawImage(Look, centre - CentreInLook);
			g.DrawString(number.ToString(), new Font(FontFamily.GenericSerif, 10), Brushes.Black, centre - (2, 5));
			foreach (Detail child in Children)
				child.Show(g);
		}

		/// <summary>
		/// Функция для драгдропа детали из списка сохраненных в рабочее поле
		/// </summary>
		/// <returns></returns>
		public Detail Clone(Vector position)
		{
			Detail clone = (Detail)MemberwiseClone();
			clone.Children = new List<Detail>();
			clone.centre += position;
			return clone;
		}

		public Detail(Bitmap look, decimal mass)
		{
			centre = (0, 0);
			j = 0;
			Children = new List<Detail>();

			Look = new Bitmap(look);
			m = mass;
			int square = 0;
			for (int x = 0; x < Look.Width; x++)
				for (int y = 0; y < Look.Height; y++)
					if (Look.GetPixel(x, y) != Color.FromArgb(255, 0, 0, 0))
					{
						square++;
						Vector cur = (x, y);
						centre += cur;
						j += cur.SquaredLength;
					}
					else
						Look.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
			centre /= square;
			j *= m / square;
			CentreInLook = centre;
		}
	}
}
