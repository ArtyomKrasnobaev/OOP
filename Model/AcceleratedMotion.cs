using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AcceleratedMotion : MotionBase
    {
        public double Acceleration { get; set; }

        public override double CalculateCoordinate()
        {
            return InitialValue + (Velocity * Time) + (Acceleration * Math.Pow(Time, 2)) / 2;
        }
    }
}
