using System;
using System.Collections.Generic;
using System.Text;

namespace Figure
{
    public struct UDouble   //Positive Double
    {
        private double value;        

        public UDouble (double v)
        {
            if(v<=0)
                throw new Exception("Value must be positive.");
            value = v;
        }

        public static implicit operator double(UDouble d)
        {
            return d.value;
        }

        public static implicit operator UDouble(double v)
        {
            if (v <= 0)
                throw new Exception("Value must be positive");
            return new UDouble(v);
        }
    }
}
