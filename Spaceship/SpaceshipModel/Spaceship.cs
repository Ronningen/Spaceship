﻿using System.Collections.Generic;
using System.Drawing;

using SpaceshipModel.ShortMath;

using static System.Math;

namespace SpaceshipModel
{
	public class Spaceship
	{
		public Vector position;
		private Vector linearVelocity;
		public decimal angle;
		private decimal angularVelocity;

		public Detail Body { get; private set; }
		public List<Engine> Engines { get; private set; }

		public void Evulate(int width, int height)
		{
			Body.Update();
			Accelerate();
			Move(width, height);
		}

		private void Accelerate()
		{
			foreach (Engine engine in Engines)
			{
				linearVelocity -= engine.Force / Body.M;
				Vector f = engine.Force;
				Vector r = engine.GetDist(Body);
				angularVelocity -= (f.Y * r.X - f.X * r.Y) / Body.J / (decimal)PI * 180;
			}
		}

		private void Move(int width, int height)
		{
			position += linearVelocity;
			Vector showPosition = position + Body.Centre;
			if (showPosition.X < 0)
				position.X = width - Body.Centre.X;
			if (showPosition.Y < 0)
				position.Y = height - Body.Centre.Y;
			if (showPosition.X > width)
				position.X = -Body.Centre.X;
			if (showPosition.Y > height)
				position.Y = -Body.Centre.Y;
			angle += angularVelocity;
			angle %= 360;
		}

		/// <summary>
		/// Обновляет список двигателей.
		/// </summary>
		public void Update()
		{
			Body.Update();
			Engines = Body.AggregateEngines();
		}

		public void Show(Graphics g, bool showOffset = false)
		{
			PointF offset = position + Body.Centre;
			if (showOffset)
			{
				g.TranslateTransform(offset.X, offset.Y);
				g.RotateTransform((float)angle);
				g.TranslateTransform(-(float)Body.Centre.X, -(float)Body.Centre.Y);
			}
			Body.Show(g);
			if (showOffset)
			{
				g.TranslateTransform((float)Body.Centre.X, (float)Body.Centre.Y);
				g.RotateTransform(-(float)angle);
				g.TranslateTransform(-offset.X, -offset.Y);
			}
		}

		public Spaceship(Detail detail)
		{
			position = (0, 0);
			linearVelocity = (0, 0);
			angle = 0;
			angularVelocity = 0;
			Body = detail;
			Body.Update();
			Engines = Body.AggregateEngines();
		}

		public Spaceship Detach(Detail detail)
		{
			decimal squaredDistance = (Body.Centre - detail.Centre).SquaredLength;
			decimal deltaMomentum = angularVelocity * detail.J + detail.M * squaredDistance;
			if (Body.Detach(detail))
			{
				Spaceship spaceship = new Spaceship(detail);
				spaceship.position = position;
				spaceship.linearVelocity = linearVelocity + (Vector)(Cos((double)angle), Sin((double)angle)) * angularVelocity * (decimal)Sqrt((double)squaredDistance);
				spaceship.angle = angle;

				Update();
				linearVelocity -= spaceship.linearVelocity * spaceship.Body.M / Body.M;
				angularVelocity -= deltaMomentum / Body.J;

				return spaceship;
			}
			return null;
		}

		public bool Attach(Detail detail)
		{
			if (Body.Attach(detail))
			{
				Update();
				return true;
			}
			return false;
		}
	}
}