using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class MotionRandom
    {
        private static Random _random = new Random();

        private const _minValue = 0;


        public ConstantMotion GetRandomConstantMotion()
        {
            ConstantMotion constantMotion = new();
        }
    }
}
