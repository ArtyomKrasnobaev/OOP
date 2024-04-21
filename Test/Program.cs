using PersonLib;
namespace Test
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод вывода данных полей объекта класса Person в консоль.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public static void PrintPersonToConsole(PersonBase person)
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
            Random random = new Random();
            PersonList personList = new PersonList();
            for (int i = 0; i < 15; i++)
            {
                int randomClass = random.Next(2);
                if (randomClass == 0)
                {
                    personList.AddPerson(RandomPerson.GetRandomAdult());
                }
                else
                {
                    personList.AddPerson(RandomPerson.GetRandomChild());
                }
            }

            Console.WriteLine(personList.GetPersonListInfo());
            Console.WriteLine(personList.GetPersonByIndex(3).GetType());

            //TODO: программно определить тип
        }
    }
}