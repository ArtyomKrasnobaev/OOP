using System.Reflection.Metadata;
using Model;

namespace ConsoleLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstantMotion constantMotion = new();
            AcceleratedMotion acceleratedMotion = new();
            OscillatoryMotion ocscillatoryMotion = new();
            Console.Write("Начальное значение: ");
            constantMotion.InitialValue = Convert.ToDouble(Console.ReadLine());
            acceleratedMotion.InitialValue = constantMotion.InitialValue;
            ocscillatoryMotion.InitialValue = constantMotion.InitialValue;
            Console.Write("Скорость: ");
            constantMotion.Velocity = Convert.ToDouble(Console.ReadLine());
            acceleratedMotion.Velocity = constantMotion.Velocity;
            ocscillatoryMotion.Velocity = constantMotion.Velocity;
            Console.Write("Время: ");
            constantMotion.Time = Convert.ToDouble(Console.ReadLine());
            acceleratedMotion.Time = constantMotion.Time;
            ocscillatoryMotion.Time = constantMotion.Time;
            Console.Write("Ускорение: ");
            acceleratedMotion.Acceleration = Convert.ToDouble(Console.ReadLine());
            Console.Write("Амплитуда: ");
            ocscillatoryMotion.Amplitude = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Равномерное движение: {constantMotion.CalculateCoordinate()}");
            Console.WriteLine($"Равноускоренное движение: {acceleratedMotion.CalculateCoordinate()}");
            Console.WriteLine($"Колебательное движение: {ocscillatoryMotion.CalculateCoordinate()}");
        }
    }
}