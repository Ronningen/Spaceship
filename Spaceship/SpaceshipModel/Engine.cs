using System.Drawing;

using SpaceshipModel.ShortMath;

using static System.Math;

namespace SpaceshipModel
{
	public class Engine : Detail
	{
		public double CosDir { get; }
		public double SinDir { get; }

		private decimal coef;
		private decimal maxForce;

		/// <summary>
		/// Развиваемая двигателем в данный момент сила на еденицу времени 
		/// (или изменение линейного импульса за эту единицу времени)
		/// </summary>
		public Vector Force { get => maxForce * coef * (Vector)(CosDir, SinDir); }

		/// <summary>
		/// Относительная мощность двигателя;
		/// коэффициент, указывающий эффективность работы двигателя в данный момент
		/// (в доле от макс.силы, то есть от нуля до единицы).
		/// </summary>
		public decimal ForceCoef
		{
			get => coef;
			set
			{
				if (value < 0)
					coef = 0;
				else if (value > 1)
					coef = 1;
				else
					coef = value;
			}
		}

		public Engine(Bitmap look, decimal mass, decimal maxForce, double direction) : base(look, mass)
		{
			direction = -direction / 180 * PI;
			CosDir = Cos(direction);
			SinDir = Sin(direction);
			coef = 0;
			this.maxForce = maxForce;
		}

		public override void Show(Graphics g)
		{
			base.Show(g);
			g.FillEllipse(Brushes.Red, (float)centre.X - 5, (float)centre.Y - 5, 10, 10);
			g.DrawLine(new Pen(Color.Orange, 3), centre, centre + (decimal)Force.Length / M * (Vector)(CosDir, SinDir) + 10 * (Vector)(CosDir, SinDir));
		}

		public Vector GetDist(Detail detail)
		{
			return centre - detail.Centre;
		}

		public override string ToString()
		{
			return type + number + " max force:" + maxForce;
		}
	}
}
