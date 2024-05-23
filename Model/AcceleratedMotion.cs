using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс равноускоренного движения.
    /// </summary>
    public class AcceleratedMotion : MotionBase
    {
        /// <summary>
        /// Ускорение.
        /// </summary>
        public double Acceleration { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Координата.</returns>
        public override double CalculateCoordinate()
        {
            return InitialValue + (Velocity * Time) + 
                (Acceleration * Math.Pow(Time, 2)) / 2;
        }
    }
}
