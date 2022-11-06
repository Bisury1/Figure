using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : ICircle
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Вы ввели неверное значение!");
                radius = value;
            }
        }

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
