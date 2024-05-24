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
        /// <returns>Движение.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static MotionBase ReadMotion()
        {
            MotionBase motion = new ConstantMotion();

            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("1 - равномерное\n" +
                        "2 - равноускоренное\n" +
                        "3 - колебательное\n" +
                        "Выберите тип движения: ");
                },

                () =>
                {
                    int inputMotion = Convert.ToInt32(Console.ReadLine());
                    switch (inputMotion)
                    {
                        case 1:
                        {
                            motion = ReadConstantMotion();
                            break;
                        }
                        case 2:
                        {
                            motion = ReadAcceleratedMotion();
                            break;
                        }
                        case 3:
                        {
                            motion = ReadOscillatoryMotion();
                            break;
                        }
                        default:
                        {
                            throw new ArgumentException
                                ("\nВыберите тип движения из" +
                                " представленных на экране");
                        }
                    }
                },
            };

            ActionHandler(actions);

            return motion;
        }

        /// <summary>
        /// Метод чтения равномерного движения.
        /// </summary>
        /// <returns>Равномерное движение.</returns>
        public static ConstantMotion ReadConstantMotion()
        {
            ConstantMotion constantMotion = new ConstantMotion();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите начальную координату: ");
                    constantMotion.InitialValue = 
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    //TODO+: RSDN
                    Console.Write("Введите скорость, м/с: ");
                    constantMotion.Velocity = 
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите время, с: ");
                    constantMotion.Time = 
                        Convert.ToDouble(Console.ReadLine());
                }
            };

            ActionHandler(actions);
            return constantMotion;
        }

        /// <summary>
        /// Метод чтения равноускоренного движения.
        /// </summary>
        /// <returns>Равноускоренное движение.</returns>
        public static AcceleratedMotion ReadAcceleratedMotion()
        {
            AcceleratedMotion acceleratedMotion = new AcceleratedMotion();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите начальную координату: ");
                    acceleratedMotion.InitialValue =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите скорость, м/с: ");
                    acceleratedMotion.Velocity =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите ускорение, м/с^2: ");
                    acceleratedMotion.Acceleration =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите время, с: ");
                    acceleratedMotion.Time = 
                        Convert.ToDouble(Console.ReadLine());
                }
            };

            ActionHandler(actions);
            return acceleratedMotion;
        }

        /// <summary>
        /// Метод чтения колебательного движения.
        /// </summary>
        /// <returns>Колебательное движение.</returns>
        public static OscillatoryMotion ReadOscillatoryMotion()
        {
            OscillatoryMotion oscillatoryMotion = new OscillatoryMotion();
            var actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите начальную координату: ");
                    oscillatoryMotion.InitialValue = 
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите амплитуду колебаний, м: ");
                    oscillatoryMotion.Amplitude =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите время, с: ");
                    oscillatoryMotion.Time =
                        Convert.ToDouble(Console.ReadLine());
                },

                () =>
                {
                    Console.Write("Введите частоту колебаний, Гц: ");
                    oscillatoryMotion.Frequency = 
                        Convert.ToDouble(Console.ReadLine());
                },
            };

            ActionHandler(actions);
            return oscillatoryMotion;
        }

        /// <summary>
        /// Обработчик действий.
        /// </summary>
        /// <param name="actions"></param>
        private static void ActionHandler(List<Action> actions)
        {
            Dictionary<Type, Action<string>> catchDictionary =
                new Dictionary<Type, Action<string>>()
            {
                {
                    typeof(FormatException),
                    (string message) =>
                    {
                        Console.WriteLine($"Некорректный формат ввода");
                    }
                },

                {
                    typeof(ArgumentException),
                    Console.WriteLine
                },
            };

            foreach (var action in actions)
            {
                while (true)
                {
                    try
                    {
                        action.Invoke();
                        break;
                    }
                    catch (Exception exception)
                    {
                        catchDictionary[exception.GetType()].
                            Invoke(exception.Message);
                    }
                }
            }
        }
    }
}
