using System;
using Xunit;
using Shapes;

namespace ShapesTest {
    public class TriangleTest {
        [Fact]
        public void TriangleAreaTest() {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.GetArea(), 3);
            triangle = new Triangle(5, 5, 8);
            Assert.Equal(12, triangle.GetArea(), 3);
            Shape triangleCT = new Triangle(4, 7, 9);
            Assert.Equal(13.4164, triangleCT.GetArea(), 4);
            triangleCT = new Triangle(3, 4, 5);
            Assert.Equal(6, triangleCT.GetArea(), 3);
        }

        [Fact]
        public void IsRightTriangleTest() {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTrianle());
            triangle = new Triangle(5, 5, 8);
            Assert.False(triangle.IsRightTrianle());
            triangle = new Triangle(4, 7, 9);
            Assert.False(triangle.IsRightTrianle());
        }

        [Fact]
        public void TriangleNotPositiveSidesException() {
            Assert.Throws<ArgumentException>(() => new Triangle(4, 0, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 10, 12));
        }

    }
}
