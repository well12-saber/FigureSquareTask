using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Figure
{
    public class Circle : AbstractFigure
    {
        private UDouble r;
        public Circle(double x)
        {            
            r = x;
        }
        public override double getSquare()
        {
            return Math.PI * Math.Pow(r,2);
        }
    }
}
