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
                Console.WriteLine
                    ("Для начала работы нажмите любую клавишу...\n");

                Console.ReadKey();
                
                MotionBase motion = MotionReader.ReadMotion();
                Console.WriteLine(Math.Round
                    (motion.CalculateCoordinate(), 2));
            }
        }
    }
}