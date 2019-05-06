using System;
using System.Collections.Generic;
using System.Text;

namespace LastBastion.Model
{
    public class Vectors
    {
        double _x;
        double _y;

        public Vectors (double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double PosX
        {
            get { return _x; }
            set { _x = value; }
        }

        public double PosY
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Magnitude => Math.Sqrt((_x * _x) + (_y * _y));
    }
}
