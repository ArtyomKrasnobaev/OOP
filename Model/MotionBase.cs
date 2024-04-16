using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class MotionBase
    {
        public double InitialValue { get; set; }

        public double Velocity { get; set; }

        public double Time { get; set; }

        public abstract double CalculateCoordinate();
    }
}