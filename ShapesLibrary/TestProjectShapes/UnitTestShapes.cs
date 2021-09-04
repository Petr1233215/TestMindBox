using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesLibrary.ShapeCreator;
using ShapesLibrary.Shapes;
using System;

namespace TestProjectShapes
{
	[TestClass]
	public class UnitTestShapes
	{
		/// <summary>
		/// �������� �������������� �������
		/// </summary>
		[TestMethod]
		public void TestMethodCircleNegativeRadius()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CircleCreator(-1));
		}

		/// <summary>
		/// �������� ������� �����
		/// </summary>
		[TestMethod]
		public void TestCircleArea()
		{
			double circleArea = new CircleCreator(3).GetShape().GetArea();

			Assert.AreEqual(28.274333882308138, circleArea);
		}

		/// <summary>
		/// �������� ������������� ������
		/// </summary>
		[TestMethod]
		public void TestNegativeTriangleSides()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TriangleCreator(new TriangleStructure(-1, 2, 2)));

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TriangleCreator(new TriangleStructure(1, -2, 2)));

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TriangleCreator(new TriangleStructure(-1, -2, -2)));
		}

		/// <summary>
		/// �������� ������� ������������
		/// </summary>
		[TestMethod]
		public void TestTriangleArea()
		{
			double triangleArea = new TriangleCreator(new TriangleStructure(3, 4, 5))
				.GetShape()
				.GetArea();

			Assert.AreEqual(6, triangleArea);
		}

		/// <summary>
		/// ��������, �� �� ��� ����������� �������� �������������
		/// </summary>
		[TestMethod]
		public void TestTriangleCheckRectangular()
		{
			Triangle triangle = (Triangle) new TriangleCreator(new TriangleStructure(3, 4, 5)).GetShape();

			var isRectangular = triangle.CheckRectangular();

			Assert.AreEqual(true, isRectangular);
		}

		/// <summary>
		/// ��������, �� �� ��� ����������� �� �������� �������������
		/// </summary>
		[TestMethod]
		public void TestTriangleNotCheckRectangular()
		{
			Triangle triangle = (Triangle)new TriangleCreator(new TriangleStructure(3, 4, 3)).GetShape();

			var isRectangular = triangle.CheckRectangular();

			Assert.AreEqual(false, isRectangular);
		}
	}
}
