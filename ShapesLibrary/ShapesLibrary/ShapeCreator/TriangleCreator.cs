using ShapesLibrary.Shapes;

namespace ShapesLibrary.ShapeCreator
{
	public class TriangleCreator: IShapeCreator
	{
		private TriangleStructure TriangleStructure;

		public TriangleCreator(TriangleStructure triangleStructure)
		{
			TriangleStructure = triangleStructure;
		}

		public IShape GetShape() => new Triangle(TriangleStructure);
	}
}
