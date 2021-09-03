using System;

namespace ShapesLibrary.Shapes
{
	public struct TriangleStructure
	{
		/// <summary>
		/// 1 сторона
		/// </summary>
		public double A { get; set; }

		/// <summary>
		/// 2 сторона
		/// </summary>
		public double B { get; set; }

		/// <summary>
		/// 3 сторона
		/// </summary>
		public double C { get; set; }

		public TriangleStructure(double a, double b, double c)
		{
			if(a < 0 || b < 0 || c < 0)
				throw new ArgumentOutOfRangeException("Стороны треугольника не могут быть отрицательными");

			A = a;
			B = b;
			C = c;
		}
	}
}
