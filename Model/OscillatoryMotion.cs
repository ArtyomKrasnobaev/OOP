using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс колебательного движения.
    /// </summary>
    public class OscillatoryMotion : MotionBase
    {
        /// <summary>
        /// Амплитуда колебаний.
        /// </summary>
        private double _amplitude;

        /// <summary>
        /// Частота колебаний.
        /// </summary>
        private double _frequency;

        /// <summary>
        /// Амплитуда колебаний.
        /// </summary>
        public double Amplitude
        { 
            get { return _amplitude; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Введите положительное значение амплитуды");
                }
                _amplitude = value;
            }
        }

        /// <summary>
        /// Частота колебаний.
        /// </summary>
        public double Frequency
        {
            get { return _frequency; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Введите положительное значение частоты в Гц");
                }
                _frequency = value;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns>Координата.</returns>
        public override double CalculateCoordinate()
        {
            return Amplitude * Math.Sin(InitialValue + (Frequency * Time));
        }
    }
}
