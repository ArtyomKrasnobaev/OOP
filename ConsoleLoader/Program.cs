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
            MotionReader.ReadMotion();
        }
    }
}