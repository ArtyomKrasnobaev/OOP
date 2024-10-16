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
        /// Поле скорости.
        /// </summary>
        private double _velocity;

        /// <summary>
        /// Скорость.
        /// </summary>
        public double Velocity
        { 
            get { return _velocity; } 
            set
            {
                if (double.IsNaN(value))
                {
                    throw new ArgumentException
                        ("Введите корректное значение скорости");
                }

                _velocity = value;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Координата.</returns>
        public override double CalculateCoordinate()
        {
            return InitialValue + (Velocity * Time);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Тип движения.</returns>
        public override string MotionType
        {
            get
            {
                return "Равномерное";
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Параметры движения.</returns>
        public override string Parameters
        {
            get
            {
                return $"v = {Velocity}";
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Координата.</returns>
        public override double Coordinate
        {
            get
            {
                return Math.Round(InitialValue + (Velocity * Time), 2);
            }
        }
    }
}