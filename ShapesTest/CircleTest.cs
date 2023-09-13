using System;
using Xunit;
using Shapes;

namespace ShapesTest {
    public class CircleTest {
        [Fact]
        public void CircleAreaTest() {
            Circle circle = new Circle(3);
            Assert.Equal(Math.PI * 9, circle.GetArea(), 3);
            circle = new Circle(5);
            Assert.Equal(Math.PI * 25, circle.GetArea(), 3);
            circle = new Circle(10);
            Assert.Equal(Math.PI * 100, circle.GetArea(), 3);
            Shape circleCT = new Circle(1);
            Assert.Equal(Math.PI, circleCT.GetArea(), 3);
        }

        [Fact]
        public void CircleNotPositiveRadiusException() {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
