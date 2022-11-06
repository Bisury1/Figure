using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : ITriangle
    {
        private double _sideAB;
        private double _sideBC;
        private double _sideAC;
        private bool? _isRightTriangle;
        public Triangle(double sideAB, double sideBC, double sideAC)
        {
            SideAB = sideAB;
            SideBC = sideBC;
            SideAC = sideAC;
            if(!CheckTriangleInequality(SideAB, SideBC, SideAC))
            {
                throw new ArgumentException("Треугольника с такими сторонами быть не может!");
            }
        }
        public double SideAB
        {
            get => _sideAB;
            set
            {
                if (CheckSide(value))
                {
                    _sideAB = value;
                }
                else
                    throw new ArgumentException("Введите верное значение!");
            }
        }

        public double SideBC
        {
            get => _sideBC;
            set
            {
                if (CheckSide(value))
                {
                    _sideBC = value;
                }
                else
                    throw new ArgumentException("Введите верное значение!");
            }
        }
        public double SideAC
        {
            get => _sideAC;
            set
            {
                if (CheckSide(value))
                {
                    _sideAC = value;
                }
                else
                    throw new ArgumentException("Введите верное значение!");
            }
        }

        public bool IsRightTriangle
        {
            get
            {
                if(_isRightTriangle == null)
                    _isRightTriangle = CheckTriangleForRectangularity(SideAB, SideBC, SideAC);
                return _isRightTriangle.Value;
            }
        }
        private bool CheckSide(double value)
        {
            if (value > 0)
                return true;
            return false;
        }
        private bool CheckTriangleForRectangularity(double sideAB, double sideBC, double sideAC)
        {
            double maxSide = sideAB, a = sideBC, b = sideAC;
            if(a - maxSide > 0)
            {
                Swapper.Swap(ref maxSide, ref a);
            }
            if(b - maxSide > 0)
            {
                Swapper.Swap(ref maxSide, ref b);
            }
            return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(a,2) - Math.Pow(b, 2)) < 0.00000001;
        }
        public bool CheckTriangleInequality(double sideAB, double sideBC, double sideAC)
        { 
            if(sideAB + sideBC < sideAC)
            {
                return false;
            }
            if (sideBC + sideAC < sideAB)
            {
                return false;
            }
            if (sideAB + sideAC < sideBC)
            {
                return false;
            }
            return true;
        }
        public double GetSquare()
        {
            double semiperimetr = (SideAB + SideAC + SideBC) / 2.0;
            double square = Math.Sqrt(semiperimetr *
                (semiperimetr - SideAB) * 
                (semiperimetr - SideBC) * 
                (semiperimetr - SideAC));
            return square;
        }
    }
}
