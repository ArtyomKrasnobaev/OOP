using Persons;
using System;

namespace Lab1
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
            bool incorrectData = false;

            do
            {
                try
                {
                    Console.Write("Введите имя: ");
                    person.FirstName = Console.ReadLine();
                    incorrectData = false;
                }
                catch (Exception ex)
                {
                    incorrectData = true;
                    Console.WriteLine(ex.Message);
                }
            }
            while (incorrectData);

            do
            {
                try
                {
                    Console.Write("Введите фамилию: ");
                    person.LastName = Console.ReadLine();
                    incorrectData = false;
                }
                catch (Exception ex)
                {
                    incorrectData = true;
                    Console.WriteLine(ex.Message);
                }
            }
            while (incorrectData);

            do
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    incorrectData = false;
                }
                catch (FormatException)
                {
                    incorrectData = true;
                    Console.WriteLine("Возраст не может содержать символов");
                }
                catch (ArgumentException ex)
                {
                    incorrectData = true;
                    Console.WriteLine(ex.Message);
                }
            }
            while (incorrectData);

            Console.Write("Введите пол (М - мужской; Ж - женский): ");
            string genderFromConsole = Console.ReadLine();
            
            if (genderFromConsole == "М" | genderFromConsole == "м")
            {
                person.Gender = Gender.Male;
            }
            if (genderFromConsole == "Ж" | genderFromConsole == "ж")
            {
                person.Gender = Gender.Female;
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

        static void Main(string[] args)
        {
            Person randomPerson = Person.GetRandomPerson();
            PrintPersonToConsole(randomPerson);

            Person personFromConsole = CreatePersonFromConsole();
            PrintPersonToConsole(personFromConsole);

            // Объекты класса Person для тестирования
            Person person1 = new Person("Леон", "Кеннеди", 27, Gender.Male);
            Person person2 = new Person("Крис", "Редфилд", 30, Gender.Male);
            Person person3 = new Person("Ада", "Вонг", 26, Gender.Female);
            Person person4 = new Person("Джилл", "Валентайн", 25, Gender.Female);
            Person person5 = new Person("Эшли", "Грэм", 19, Gender.Female);
            Person person6 = new Person("Альберт", "Вескер", 40, Gender.Male);
            Person person7 = new Person("Итан", "Винтерс", 34, Gender.Male);

            // Объекты класса PersonList для тестирования
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

            Console.ReadKey();
            personList1.AddPerson(person7);
            Console.WriteLine("В список 1 добавлен новый человек\n");
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