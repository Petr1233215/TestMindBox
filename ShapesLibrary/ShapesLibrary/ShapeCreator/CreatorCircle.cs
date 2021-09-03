using ShapesLibrary.Shapes;

namespace ShapesLibrary.ShapeCreator
{
	public class CreatorCircle : IShapeCreator
	{
		private double Radius { get; set; }

		public CreatorCircle(double radius)
		{
			Radius = radius;
		}

		public IShape GetShape() => new Circle(Radius);
	}
}
