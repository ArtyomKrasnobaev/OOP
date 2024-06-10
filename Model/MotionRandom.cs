using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class MotionRandom
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

        public static double GetRandomDouble()
        {
            double randomDouble = _random.Next(_minValue, _maxValue);
            return randomDouble;
        }

        public static MotionBase GetRandomMotion()
        {
            var motion = _random.Next(0, 2);
            switch (motion)
            {
                case 0:
                {
                    return GetRandomConstantMotion();
                }
                case 1:
                {
                    return GetRandomAcceleratedMotion();
                }
                case 2:
            }
        }

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

        public static AcceleratedMotion GetRandomAcceleratedMotion()
        {
            AcceleratedMotion acceleratedMotion = new();
            SetRandomMotionBaseData(acceleratedMotion);
            acceleratedMotion.Velocity = GetRandomDouble();
            acceleratedMotion.Acceleration = GetRandomDouble();
            return acceleratedMotion;
        }

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
