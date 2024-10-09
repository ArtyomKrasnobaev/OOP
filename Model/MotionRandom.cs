using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MotionRandom
    {
        /// <summary>
        /// Объект класса Random.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Константа минимального значения рандома.
        /// </summary>
        private const int _minValue = 1;

        /// <summary>
        /// Константа максимального значения рандома.
        /// </summary>
        private const int _maxValue = 100;

        /// <summary>
        /// Метод генерации случайного числа типа double.
        /// </summary>
        /// <returns></returns>
        public static double GetRandomDouble()
        {
            double randomDouble = _random.Next(_minValue, _maxValue);
            return randomDouble;
        }

        /// <summary>
        /// Метод генерации случайного движения.
        /// </summary>
        /// <returns></returns>
        public static MotionBase GetRandomMotion()
        {
            int motionNumber = _random.Next(0, 3);
            switch (motionNumber)
            {
                case 0:
                {
                    return GetRandomConstantMotion();
                }
                case 1:
                {
                    return GetRandomAcceleratedMotion();
                }
                default:
                {
                    return GetRandomOscillatoryMotion();
                }
            }
        }

        /// <summary>
        /// Метод установки общих параметров класса.
        /// </summary>
        /// <param name="motionBase"></param>
        public static void SetRandomMotionBaseData(MotionBase motionBase)
        {
            motionBase.InitialValue = GetRandomDouble();
            motionBase.Time = GetRandomDouble();
        }

        /// <summary>
        /// Метод генерации рандомного равномерного движения.
        /// </summary>
        /// <returns>Объект класса ConstantMotion.</returns>
        public static ConstantMotion GetRandomConstantMotion()
        {
            ConstantMotion constantMotion = new();
            SetRandomMotionBaseData(constantMotion);
            constantMotion.Velocity = GetRandomDouble();
            return constantMotion;
        }

        /// <summary>
        /// Метод генерации рандомного равноускоренного движения.
        /// </summary>
        /// <returns></returns>
        public static AcceleratedMotion GetRandomAcceleratedMotion()
        {
            AcceleratedMotion acceleratedMotion = new();
            SetRandomMotionBaseData(acceleratedMotion);
            acceleratedMotion.Velocity = GetRandomDouble();
            acceleratedMotion.Acceleration = GetRandomDouble();
            return acceleratedMotion;
        }

        /// <summary>
        /// Метод генерации рандомного колебательного движения.
        /// </summary>
        /// <returns></returns>
        public static OscillatoryMotion GetRandomOscillatoryMotion()
        {
            OscillatoryMotion oscillatoryMotion = new();
            SetRandomMotionBaseData(oscillatoryMotion);
            oscillatoryMotion.Amplitude = GetRandomDouble();
            oscillatoryMotion.Frequency = GetRandomDouble();
            return oscillatoryMotion;
        }
    }
}
