using System;
using System.Linq;

namespace ShapesLibrary.Shapes
{
	public class Triangle : IShape
	{
		private TriangleStructure StructTriangle { get; set; }

		public Triangle(TriangleStructure triangleStructure)
		{
			StructTriangle = triangleStructure;
		}

		//Площаль находится по формуле Герона
		public double GetArea()
		{
			double perimeter = (StructTriangle.A + StructTriangle.B + StructTriangle.C) / 2;
			return Math.Sqrt(perimeter * (perimeter - StructTriangle.A) * (perimeter - StructTriangle.B) * (perimeter - StructTriangle.C));
		}

		/// <summary>
		/// Метод определяющий является ли треугольник прямоугольным
		/// </summary>
		/// <returns></returns>
		public bool CheckRectangular()
		{
			var arraySides = new double[] { StructTriangle.A, StructTriangle.B, StructTriangle.C };
			var hypotenuse = arraySides.Max();
			var cathetusSides = arraySides.Where(c => c != hypotenuse);

			return Math.Pow(hypotenuse, 2) == cathetusSides.Aggregate((a, b) => Math.Pow(a,2) + Math.Pow(b, 2));
		}
	}
}
