using System;

namespace ShapesLibrary.Shapes
{
	public class Triangle : IShape, ITriangle
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

		public bool CheckRectangular()
		{
			double maxSide;
			double sumOtherSide;
			if (StructTriangle.A > StructTriangle.B && StructTriangle.A > StructTriangle.C)
			{
				maxSide = Math.Pow(StructTriangle.A, 2);
				sumOtherSide = Math.Pow(StructTriangle.B, 2) + Math.Pow(StructTriangle.C, 2);
			}
			else if (StructTriangle.B > StructTriangle.A && StructTriangle.B > StructTriangle.C)
			{
				maxSide = Math.Pow(StructTriangle.B, 2);
				sumOtherSide = Math.Pow(StructTriangle.A, 2) + Math.Pow(StructTriangle.C, 2);
			}
			else
			{
				maxSide = Math.Pow(StructTriangle.C, 2);
				sumOtherSide = Math.Pow(StructTriangle.A, 2) + Math.Pow(StructTriangle.B, 2);
			}

			return maxSide == sumOtherSide;
		}
	}
}
