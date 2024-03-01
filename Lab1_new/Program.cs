using Persons_new;
using System;
using System.Runtime.InteropServices;

namespace Lab1_new
{
    internal class Program
    {
        /// <summary>
        /// Метод создания объекта класса Person с клавиатуры.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person CreatePersonFromConsole()
        {
            Person person = new Person();

            //TODO: duplication
            while (true)
            {
                try
                {
                    Console.Write("Введите имя: ");
                    person.FirstName = Console.ReadLine();
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //TODO: duplication
            while (true)
            {
                try
                {
                    Console.Write("Введите фамилию: ");
                    person.LastName = Console.ReadLine();
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //TODO: duplication
            while (true)
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Возраст не может содержать символов");
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //TODO: duplication
            while (true)
            {
                try
                {
                    Console.Write("Введите пол (М - мужской;" +
                                            " Ж - женский): ");
                    string consoleGender = Console.ReadLine();
                    switch (consoleGender)
                    {
                        case "М":
                        case "м":
                            break;
                        case "Ж":
                        case "ж":
                            person.Gender = Gender.Female;
                            break;
                        default:
                            throw new Exception();
                    }

                    break;
                }

                catch (Exception)
                {
                    Console.WriteLine("Внимательнее");
                }
            }

            return person;
        }

        /// <summary>
        /// Метод вывода данных полей объекта класса Person в консоль.
        /// </summary>
        /// <param name="person"></param>
        public static void PrintPersonToConsole(Person person)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

        //TODO: xml
        static void Main(string[] args)
        {
            string frameworkDescription = RuntimeInformation.FrameworkDescription;
            Console.WriteLine(frameworkDescription);

            Person person1 = Person.GetRandomPerson();
            Person person2 = Person.GetRandomPerson();
            Person person3 = Person.GetRandomPerson();
            Person person4 = Person.GetRandomPerson();
            Person person5 = Person.GetRandomPerson();
            Person person6 = Person.GetRandomPerson();

            PersonList personList1 = new PersonList();
            PersonList personList2 = new PersonList();

            Console.ReadKey();
            personList1.AddPerson(person1);
            personList1.AddPerson(person2);
            personList1.AddPerson(person3);
            personList2.AddPerson(person4);
            personList2.AddPerson(person5);
            personList2.AddPerson(person6);
            Console.WriteLine("Созданы два списка персон\n");

            Console.ReadKey();
            Console.WriteLine($"Список 1:\n{personList1.GetPersonListInfo()}");
            Console.WriteLine($"Список 2:\n{personList2.GetPersonListInfo()}");

            Person person7 = CreatePersonFromConsole();
            Console.ReadKey();
            personList1.AddPerson(person7);
            Console.WriteLine("В список 1 добавлен введенный человек\n");
            Console.WriteLine($"Список 1:\n{personList1.GetPersonListInfo()}");

            Console.ReadKey();
            personList2.AddPerson(personList1.GetPersonByIndex(1));
            Console.WriteLine("В список 2 добавлен второй человек из списка 1\n");
            Console.WriteLine($"Список 2:\n{personList2.GetPersonListInfo()}");

            Console.ReadKey();
            personList1.RemovePersonByIndex(1);
            Console.WriteLine("Второй человек из списка 1 удалён\n");
            Console.WriteLine($"Список 1:\n{personList1.GetPersonListInfo()}");
            Console.WriteLine($"Список 2:\n{personList2.GetPersonListInfo()}");

            Console.ReadKey();
            personList2.ClearList();
            Console.WriteLine("Список 2 очищен\n");
            Console.WriteLine($"Список 2:\n{personList2.GetPersonListInfo()}");
        }
    }
}