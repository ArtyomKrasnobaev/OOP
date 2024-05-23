using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Абстрактный класс движения.
    /// </summary>
    public abstract class MotionBase
    {
        /// <summary>
        /// Поле времени.
        /// </summary>
        private double _time;

        /// <summary>
        /// Начальная координата. 
        /// </summary>
        public double InitialValue { get; set; }

        /// <summary>
        /// Скорость/частота.
        /// </summary>
        public double Velocity { get; set; }

        /// <summary>
        /// Время.
        /// </summary>
        public double Time 
        { 
            get { return _time; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException
                        ("Введите положительное значение времени");
                }
                _time = value;
            }
        }

        /// <summary>
        /// Абстрактный метод расчета координаты.
        /// </summary>
        /// <returns>Координата.</returns>
        public abstract double CalculateCoordinate();
    }
}