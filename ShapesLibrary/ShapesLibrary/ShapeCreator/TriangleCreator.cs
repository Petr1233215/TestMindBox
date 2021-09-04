using ShapesLibrary.Shapes;
using System;

namespace ShapesLibrary.ShapeCreator
{
	public class TriangleCreator: IShapeCreator
	{
		private TriangleStructure TriangleStructure;

		public TriangleCreator(TriangleStructure triangleStructure)
		{

			if (triangleStructure.A < 0 || triangleStructure.B < 0 || triangleStructure.C < 0)
				throw new ArgumentOutOfRangeException("Стороны треугольника не могут быть отрицательными");

			TriangleStructure = triangleStructure;
		}

		public IShape GetShape() => new Triangle(TriangleStructure);
	}
}
