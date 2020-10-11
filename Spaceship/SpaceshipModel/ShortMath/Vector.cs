using System;
using System.Drawing;

namespace SpaceshipModelLib.ShortMath
{
	public struct Vector
	{
		public decimal X { get; set; }
		public decimal Y { get; set; }

		public decimal SquaredLength { get => X * X + Y * Y; }
		public decimal Length { get => (decimal)Math.Sqrt((double)SquaredLength); }

		public Vector(decimal x, decimal y) { X = x; Y = y; }
		public static implicit operator Vector((int x, int y) value) => new Vector(value.x, value.y);
		public static implicit operator Vector((decimal x, decimal y) value) => new Vector(value.x, value.y);
		public static implicit operator Vector((double x, double y) value) => new Vector((decimal)value.x, (decimal)value.y);
		public static implicit operator PointF(Vector value) => new PointF((float)value.X, (float)value.Y);
		public static implicit operator Vector(PointF value) => ((decimal)value.X, (decimal)value.Y);

		public static Vector operator +(Vector a, Vector b) => (a.X + b.X, a.Y + b.Y);
		public static Vector operator -(Vector a, Vector b) => (a.X - b.X, a.Y - b.Y);
		public static Vector operator *(decimal a, Vector b) => (a * b.X, a * b.Y);
		public static Vector operator *(Vector a, decimal b) => (a.X * b, a.Y * b);
		public static Vector operator /(Vector a, decimal b) => (a.X / b, a.Y / b);
	}
}
