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
    //[XmlInclude(typeof(ConstantMotion))]
    //[XmlInclude(typeof(AcceleratedMotion))]
    //[XmlInclude(typeof(OscillatoryMotion))]
    public abstract class MotionBase
    {
        /// <summary>
        /// Поле времени.
        /// </summary>
        private double _time;

        /// <summary>
        /// Столбец типа движения.
        /// </summary>
        [DisplayName("Тип движения")]
        public abstract string MotionType { get; }

        /// <summary>
        /// Начальная координата.
        /// </summary>
        [DisplayName("Начальное значение")]
        public double InitialValue { get; set; }

        /// <summary>
        /// Время.
        /// </summary>
        [DisplayName("Время")]
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
        /// Абстрактный метод расчета координаты.
        /// </summary>
        /// <returns>Координата.</returns>
        public abstract double CalculateCoordinate();
    }
}