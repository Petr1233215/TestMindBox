using ShapesLibrary.Shapes;
using System;

namespace ShapesLibrary.ShapeCreator
{
	public class CircleCreator : IShapeCreator
	{
		private double Radius { get; set; }

		public CircleCreator(double radius)
		{
			if (radius < 0)
				throw new ArgumentOutOfRangeException("Радиус круга не может быть отрицательным");

			Radius = radius;
		}

		public IShape GetShape() => new Circle(Radius);
	}
}
