using System;

namespace Shapes {
    public class Circle : Shape {
        private readonly double radius;
        public Circle(double radius) {
            if (radius <= 0)
                throw new ArgumentException("Радиус окружности должен быть положительным");
            this.radius = radius;
        }

        public override double GetArea() {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
