using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OscillatoryMotion : MotionBase
    {
        public double Amplitude { get; set; }

        public override double CalculateCoordinate()
        {
            return Amplitude * Math.Sin(InitialValue + (Velocity * Time));
        }
    }
}
