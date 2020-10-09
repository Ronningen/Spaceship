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
		private decimal minM;
		public List<Engine> linkedEngines { get; private set; }
		public event System.Action MassUpdated;

		public Tank(Bitmap look, decimal mass, decimal minMass, decimal MTFCoef) : base(look, mass)
		{
			minM = minMass;
			this.MTFCoef = MTFCoef;
		}

		public override void Update()
		{
			if (m > minM)
			{
				j /= m;
				foreach (Engine engine in AggregateEngines(true))
					m -= (decimal)engine.Force.Length * MTFCoef * 33 / 1000;
				j *= m;
			}
			else
				m = minM;
			base.Update();
			MassUpdated?.Invoke();
		}
	}
}
