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
        /// Поле скорости.
        /// </summary>
        private double _velocity;

        /// <summary>
        /// Поле ускорения.
        /// </summary>
        private double _acceleration;

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
        /// Ускорение.
        /// </summary>
        public double Acceleration
        {
            get { return _acceleration; }
            set
            {
                if (double.IsNaN(value))
                {
                    throw new ArgumentException
                        ("Введите корректное значение ускорения");
                }

                _acceleration = value;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Координата.</returns>
        public override double CalculateCoordinate()
        {
            return InitialValue + (Velocity * Time) + 
                (Acceleration * Math.Pow(Time, 2)) / 2;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Тип движения.</returns>
        public override string MotionType
        {
            get
            {
                return "Равноускоренное";
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
                return $"v = {Velocity};\n a = {Acceleration}";
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
                return Math.Round(InitialValue + (Velocity * Time) +
                    (Acceleration * Math.Pow(Time, 2)) / 2, 2);
            }
        }
    }
}
