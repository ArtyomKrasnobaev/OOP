using Persons;
namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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