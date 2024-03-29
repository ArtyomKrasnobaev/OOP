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
                            throw new ArgumentException
                                 ("Попробуйте еще раз");
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
                        exceptionType == typeof(ArgumentException) ||
                        exceptionType == typeof(InvalidOperationException))

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
            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();

            for (int i = 0; i < 3; i++)
            {
                personList1.AddPerson(Person.GetRandomPerson());
                personList2.AddPerson(Person.GetRandomPerson());
            }

            Console.WriteLine("Нажмите любую кнопку...\n");
            Console.ReadKey();
            Console.WriteLine("Созданы два списка персон\n");

            Console.ReadKey();
            Console.WriteLine($"Список 1:\n{personList1.GetInfo()}");
            Console.WriteLine($"Список 2:\n{personList2.GetInfo()}");

            Person personFromConsole = CreatePersonFromConsole();
            Console.ReadKey();
            personList1.AddPerson(personFromConsole);
            Console.WriteLine("В список 1 добавлен введенный человек\n");
            Console.WriteLine($"Список 1:\n{personList1.GetInfo()}");

            Console.ReadKey();
            personList2.AddPerson(personList1.GetPersonByIndex(1));
            Console.WriteLine("В список 2 добавлен второй человек из списка 1\n");
            Console.WriteLine($"Список 2:\n{personList2.GetInfo()}");

            Console.ReadKey();
            personList1.RemovePersonByIndex(1);
            Console.WriteLine("Второй человек из списка 1 удалён\n");
            Console.WriteLine($"Список 1:\n{personList1.GetInfo()}");
            Console.WriteLine($"Список 2:\n{personList2.GetInfo()}");

            Console.ReadKey();
            personList2.ClearList();
            Console.WriteLine("Список 2 очищен\n");
            Console.WriteLine($"Список 2:\n{personList2.GetInfo()}");
        }
    }
}