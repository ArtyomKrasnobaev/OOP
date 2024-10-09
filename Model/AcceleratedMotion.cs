﻿using System;
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
