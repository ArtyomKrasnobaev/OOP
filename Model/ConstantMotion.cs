using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConstantMotion : MotionBase
    {
        public override double CalculateCoordinate()
        {
            return InitialValue + (Velocity * Time);
        }
    }
}