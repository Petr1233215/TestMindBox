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
		/// Првоерка отрицательного радиуса
		/// </summary>
		[TestMethod]
		public void TestMethodCircleNegativeRadius()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CircleCreator(-1));
		}

		/// <summary>
		/// Првоерка площади круга
		/// </summary>
		[TestMethod]
		public void TestCircleArea()
		{
			double circleArea = new CircleCreator(3).GetShape().GetArea();

			Assert.AreEqual(28.274333882308138, circleArea);
		}

		/// <summary>
		/// Првоерка отрицательных сторон
		/// </summary>
		[TestMethod]
		public void TestNegativeTriangleSides()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TriangleCreator(new TriangleStructure(-1, 2, 2)));

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TriangleCreator(new TriangleStructure(1, -2, 2)));

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TriangleCreator(new TriangleStructure(-1, -2, -2)));
		}

		/// <summary>
		/// Првоерка площади треугольника
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
		/// Првоерка, на то что треугольник является прямоугольным
		/// </summary>
		[TestMethod]
		public void TestTriangleCheckRectangular()
		{
			Triangle triangle = (Triangle) new TriangleCreator(new TriangleStructure(3, 4, 5)).GetShape();

			var isRectangular = triangle.CheckRectangular();

			Assert.AreEqual(true, isRectangular);
		}

		/// <summary>
		/// Првоерка, на то что треугольник не является прямоугольным
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
