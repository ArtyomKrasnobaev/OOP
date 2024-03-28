using PersonLib;
namespace Test
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод создания объекта класса Person с клавиатуры.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person CreatePersonFromConsole()
        {
            Person person = new Person();

            //TODO+: duplication
            List<Action> actions = new List<Action>()
            {
                () =>
                {
                    Console.Write("Введите имя: ");
                    person.FirstName = Console.ReadLine();
                },
                () =>
                {
                    Console.Write("Введите фамилию: ");
                    person.LastName = Console.ReadLine();
                },
                () =>
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                },
                () =>
                {
                    Console.Write("Введите пол (м/m - мужской;" +
                                            " ж/f - женский): ");
                    string inputGender = Console.ReadLine().ToUpper();
                    switch (inputGender)
                    {
                        case "М":
                        case "M":
                            break;
                        case "Ж":
                        case "F":
                            person.Gender = Gender.Female;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Внимательнее");
                    }
                }
            };

            foreach (Action action in actions)
            {
                ActionHandler(action);
            }

            return person;
        }

        /// <summary>
        /// Метод вывода данных полей объекта класса Person в консоль.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public static void PrintPersonToConsole(Person person)
        {
            Console.WriteLine(person.GetInfo());
        }

        /// <summary>
        /// Метод обработки возможных исключений.
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

                catch (Exception ex)
                {
                    var exceptionType = ex.GetType();
                    if (exceptionType == typeof(FormatException) ||
                        exceptionType == typeof(ArgumentOutOfRangeException) ||
                        exceptionType == typeof(ArgumentException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Метод Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"Случаный Person:\n{RandomPerson.GetRandomPerson().GetInfo()}");
            Console.WriteLine($"Случаный Adult:\n{RandomPerson.GetRandomAdult().GetInfo()}");
            Console.WriteLine($"Случаный Child:\n{RandomPerson.GetRandomChild().GetInfo()}");
        }
    }
}