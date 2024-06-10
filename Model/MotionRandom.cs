using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class MotionRandom
    {
        /// <summary>
        /// Объект класса Random.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Константа минимального значения.
        /// </summary>
        private const int _minValue = 0;

        /// <summary>
        /// Константа максимального значения.
        /// </summary>
        private const int _maxValue = 100;

        public static ConstantMotion GetRandomConstantMotion()
        {
            ConstantMotion constantMotion = new();
            constantMotion.InitialValue = _random.Next(_minValue, _maxValue);
            constantMotion.Velocity = _random.Next(_minValue, _maxValue);
        }
    }
}
