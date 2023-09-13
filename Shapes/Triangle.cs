using System;

namespace Shapes {
    public class Triangle : Shape {
        private readonly double a, b, c;
        public Triangle(double a, double b, double c) {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea() {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool IsRightTrianle() {
            const double e = 1e-10; //погрешность
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < e;
        }
    }
}
