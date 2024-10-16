using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Абстрактный класс движения.
    /// </summary>
    [XmlInclude(typeof(ConstantMotion))]
    [XmlInclude(typeof(AcceleratedMotion))]
    [XmlInclude(typeof(OscillatoryMotion))]
    public abstract class MotionBase
    {
        /// <summary>
        /// Поле времени.
        /// </summary>
        private double _time;

        /// <summary>
        /// Поле начальной координаты.
        /// </summary>
        private double _initialValue;

        /// <summary>
        /// Столбец типа движения.
        /// </summary>
        [DisplayName("Тип движения")]
        public abstract string MotionType { get; }

        /// <summary>
        /// Начальная координата.
        /// </summary>
        [DisplayName("Начальная координата")]
        public double InitialValue
        {
            get { return _initialValue; }
            set
            {
                if (double.IsNaN(value))
                {
                    throw new ArgumentException
                        ("Введите корректное значение начальной координаты");
                }

                _initialValue = value;
            }
        }

        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
        public double Time
        {
            get { return _time; }
            set
            {
                if (value < 0 || double.IsNaN(value))
                {
                    throw new ArgumentException
                        ("Введите положительное значение времени");
                }

                _time = value;
            }
        }

        /// <summary>
        /// Столбец параметров.
        /// </summary>
        [DisplayName("Параметры")]
        public abstract string Parameters { get; }

        /// <summary>
        /// Столбец координат.
        /// </summary>
        [DisplayName("Координата")]
        public abstract double Coordinate { get; }

        /// <summary>
        /// Метод расчета координаты.
        /// </summary>
        /// <returns>Координата.</returns>
        public abstract double CalculateCoordinate();
    }
}