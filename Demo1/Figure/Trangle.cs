using System;

namespace FigureLib
{
    public class Trangle : Figure
    {
        private double eps = 0.000001;

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Trangle(double a, double b, double c)
        {
            this.SetSides(a, b, c);
        }

        public void SetSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new FigureException($"Side of trangle can't be less that 0 or equal");
            }

            if (a + b <= c || a + c <= b || c + b <= a)
            {
                throw new FigureException($"trangle ({a}:{b}:{c}) does not exist");
            }

            this.A = a;
            this.B = b;
            this.C = c;
        }

        public bool IsRectAngle() => (IsPifagor(A, B, C) || IsPifagor(A, C, B) || IsPifagor(C, B, A));

        public override double Area() => 
            Math.Sqrt(P() 
                * (P() - this.A) 
                * (P() - this.B) 
                * (P() - this.C));

        // P - Half perimeter. Using for Heron's formula
        private double P() => (this.A + this.B + this.C) / 2;

        private bool IsPifagor(double a, double b, double c) {
            // Предполагаем, что С - гипотенуза прямоугольного треугольника
            return Math.Abs(a * a + b * b - c * c) < this.eps;
        }
    }
}
