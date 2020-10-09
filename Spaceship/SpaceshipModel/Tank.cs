using System.Collections.Generic;
using System.Drawing;

namespace SpaceshipModel
{
	public class Tank : Detail
	{
		/// <summary>
		/// Коэффициент превращения массы бака (топлива из бака) в силу двигателя на единицу времени.
		/// </summary>
		public decimal MTFCoef { get; }
		public List<Engine> linkedEngines { get; private set; }
		public event System.Action MassUpdated;

		public Tank(Bitmap look, decimal mass, decimal MTFCoef) : base(look, mass)
		{
			this.MTFCoef = MTFCoef;
		}

		public override void Update()
		{
			if (m > 0.001m)
			{
				j /= m;
				foreach (Engine engine in AggregateEngines(true))
					m -= (decimal)engine.Force.Length * MTFCoef;
				j *= m;
			}
			else
				m = 0.001m;
			base.Update();
			MassUpdated?.Invoke();
		}
	}
}
