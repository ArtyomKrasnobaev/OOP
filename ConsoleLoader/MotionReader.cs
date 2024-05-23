using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс чтения типа и параметров движения с клавиатуры.
    /// </summary>
    public class MotionReader
    {
        /// <summary>
        /// Метод чтения типа и параметров движения с клавиатуры.
        /// </summary>
        public static void ReadMotion()
        {
            MotionBase motion = new ConstantMotion();

            Action startAction = new Action(
            () =>
            {
                Console.Write("1 - равномерное\n" +
                    "2 - равноускоренное\n" +
                    "3 - колебательное\n" +
                    "Выберите тип движения: ");

                int motionNumber = Convert.ToInt32(Console.ReadLine());
                switch (motionNumber)
                {
                    case 1:
                    {
                        motion = new ConstantMotion();
                        break;
                    }
                    case 2:
                    {
                        motion = new AcceleratedMotion();
                        break;
                    }
                    case 3:
                    {
                        motion = new OscillatoryMotion();
                        break;
                    }
                    default:
                    {
                        throw new ArgumentException
                            ("Выберите тип движения из представленных");
                    }
                }
            });

            var constantMotionActions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите начальную координату: ");
                    motion.InitialValue = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите скорость, м/с: ");
                    motion.Velocity = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите время, с: ");
                    motion.Time = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    ConstantMotion constantMotion = (ConstantMotion)motion;
                    Console.Write($"Координата: {constantMotion.CalculateCoordinate()}");
                }
            };

            var acceleratedMotionActions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите начальную координату: ");
                    motion.InitialValue = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите скорость, м/с: ");
                    motion.Velocity = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите время, с: ");
                    motion.Time = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    AcceleratedMotion acceleratedMotion = (AcceleratedMotion)motion;
                    Console.Write("Введите ускорение, м/с^2: ");
                    acceleratedMotion.Acceleration = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    AcceleratedMotion acceleratedMotion = (AcceleratedMotion)motion;
                    Console.Write($"Координата: {acceleratedMotion.CalculateCoordinate()}");
                }
            };

            var oscillatoryMotionActions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите начальную координату: ");
                    motion.InitialValue = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    OscillatoryMotion oscillatoryMotion = (OscillatoryMotion)motion;
                    Console.Write("Введите частоту колебаний, Гц: ");
                    oscillatoryMotion.Frequency = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите время, с: ");
                    motion.Time = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    OscillatoryMotion oscillatoryMotion = (OscillatoryMotion)motion;
                    Console.Write("Введите амплитуду колебаний, м: ");
                    oscillatoryMotion.Amplitude = Convert.ToDouble(Console.ReadLine());
                },
                () =>
                {
                    OscillatoryMotion oscillatoryMotion = (OscillatoryMotion)motion;
                    Console.Write($"Координата: {oscillatoryMotion.CalculateCoordinate()}");
                }
            };

            ActionHandler(startAction);

            var ActionDict = new Dictionary<Type, List<Action>>
            {
                {typeof(ConstantMotion), constantMotionActions},
                {typeof(AcceleratedMotion), acceleratedMotionActions},
                {typeof(OscillatoryMotion), oscillatoryMotionActions},
            };

            foreach (var action in ActionDict[motion.GetType()])
            {
                ActionHandler(action);
            }
        }

        /// <summary>
        /// Обработчик действий.
        /// </summary>
        /// <param name="action">Действие.</param>
        public static void ActionHandler(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
            }
        }
    }
}
