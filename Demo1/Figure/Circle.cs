using System;

namespace FigureLib
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius {
            get => this.radius;
            set {
                if (value < 0) {
                    throw new FigureException($"Circle must have positive radius, {nameof(value)}");
                }

                radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(this.Radius, 2);
    }
}
