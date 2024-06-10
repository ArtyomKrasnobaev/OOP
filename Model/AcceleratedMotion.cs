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
        /// Скорость.
        /// </summary>
        public double Velocity { get; set; }

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

        public override string MotionType
        {
            get
            {
                return "Равноускоренное";
            }
        }

        public override string Parameters
        {
            get
            {
                return $"v = {Velocity}; a = {Acceleration}";
            }
        }

        public override double Coordinate
        {
            get
            {
                return InitialValue + (Velocity * Time) +
                    (Acceleration * Math.Pow(Time, 2)) / 2;
            }
        }
    }
}
