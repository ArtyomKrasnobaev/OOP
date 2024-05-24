using System.Reflection.Metadata;
using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Для выхода из программы нажмите \'x\'\n" +
                    "Для начала работы нажмите любую другую клавишу...");

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                Console.WriteLine();

                switch (userInput.KeyChar)
                {
                    case 'х':
                    case 'x':
                    case 'X':
                    case 'Х':
                    {
                        return;
                    }
                    default:
                    {
                        break;
                    }
                }
                
                MotionBase motion = MotionReader.ReadMotion();
                Console.WriteLine($"Координата: " +
                    $"{Math.Round(motion.CalculateCoordinate(), 2)}\n");
            }
        }
    }
}