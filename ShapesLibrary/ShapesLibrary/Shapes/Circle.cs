using System;

namespace ShapesLibrary.Shapes
{
	public class Circle : IShape
	{
		public double Radius { get; set; }

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double GetArea() => Radius * Radius * Math.PI;
	}

}
