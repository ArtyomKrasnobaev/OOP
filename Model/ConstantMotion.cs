using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Класс равномерного движения.
    /// </summary>
    public class ConstantMotion : MotionBase
    {
        /// <summary>
        /// Скорость.
        /// </summary>
        public double Velocity { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Координата.</returns>
        public override double CalculateCoordinate()
        {
            return InitialValue + (Velocity * Time);
        }

        public override string MotionType
        {
            get
            {
                return "Равномерное";
            }
        }

        public override string Parameters
        {
            get
            {
                return $"v = {Velocity}";
            }
        }

        public override double Coordinate
        {
            get
            {
                return Math.Round(InitialValue + (Velocity * Time), 2);
            }
        }
    }
}