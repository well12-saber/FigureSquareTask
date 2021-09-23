using System;
using static System.Math;

namespace Figure
{
    public class Triangle : AbstractFigure
    {
        private UDouble a;
        private UDouble b;
        private UDouble c;
        public Triangle (double x, double y, double z) {            
            if ((x+y<z) || (x + z < y) || (y + z < x))
                throw new Exception("Triangle doesn't exist.");
            a = x;
            b = y;
            c = z;
        }

        public override double getSquare()
        {
            double p = (a + b + c)/2;
            return Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool checkReck()
        {
            if ((Pow(a,2)==(Pow(b, 2)+ Pow(c, 2))) 
                || (Pow(b, 2) == (Pow(a, 2) + Pow(c, 2))) 
                || (Pow(c, 2) == (Pow(a, 2) + Pow(b, 2))))
                return true;
            else
                return false;
        }

    }
}
