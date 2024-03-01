using System;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Persons_new
{
    /// <summary>
    /// класс Person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Поле имени.
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Поле фамилии.
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Поле возраста.
        /// </summary>
        private int _age;

        /// <summary>
        /// Поле пола.
        /// </summary>
        private readonly Gender _gender;

        /// <summary>
        /// Объект класса Person по умолчанию.
        /// </summary>
        public Person() : this("Неизвестно", "Неизвестно", 0, Gender.Male)
        { }

        /// <summary>
        /// Конструктор объекта класса Person.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        public Person(string firstName, string lastName, int age, Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
        }

        /// <summary>
        /// Свойство для получения доступа к полю _firstName
        /// объекта класса Person.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = VerifyName(value);
            }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _lastName
        /// объекта класса Person.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = VerifyName(value);
            }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _age
        /// объекта класса Person.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                //TODO: duplication
                if (value < 1 || value > 122)
                {
                    throw new ArgumentException("Введите возраст в " +
                        //TODO: duplication
                        "диапазоне от 1 до 122");
                }

                _age = value;
            }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _gender
        /// объекта класса Person.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Метод получения данных объекта.
        /// </summary>
        /// <returns>Строка с данными полей объекта 
        /// класса Person.</returns>
        public string GetPersonInfo()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}," +
                   $" Возраст: {Age}, Пол: {Gender}\n";
        }

        /// <summary>
        /// Метод проверки правильности имени и фамилии.
        /// </summary>
        /// <param name="name">Строка.</param>
        /// <returns>Преобразованная строка.</returns>
        /// <exception cref="Exception"></exception>
        public string VerifyName(string name)
        {
            string verifiedName = "";
            if (Regex.IsMatch(name, @"(^[а-яА-Я]+-?[а-яА-Я]+$)") ||
                Regex.IsMatch(name, @"(^[a-zA-Z]+-?[a-zA-Z]+$)"))
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                return verifiedName = ti.ToTitleCase(name);
            }

            else
            {
                throw new Exception("Имя и фамилия должны содержать " +
                    "только русские или английские символы");
            }
        }

        /// <summary>
        /// Метод генерации случайного объекта класса Person.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person GetRandomPerson()
        {
            Person person = new Person();

            List<string> maleFirstNameList = new List<string>()
            {
                "Андрей", "Борис", "Владимир", "Дмитрий", "Михаил",
                "Антон", "Глеб", "Вячеслав", "Егор", "Алексей"
            };

            List<string> femaleFirstNameList = new List<string>()
            {
                "Анна", "Елизавета", "Валерия", "Анастасия", "Наталья",
                "Евгения", "Виктория", "Екатерина", "Ангелина", "Вера"
            };

            List<string> lastNameList = new List<string>()
            {
                "Иванов", "Алексеев", "Павлов", "Васильев", "Малов",
                "Умаров", "Наумов", "Андреев", "Бобров", "Копцев"
            };

            Random random = new Random();

            person.Gender = (Gender)random.Next(Enum.GetValues
                                     (typeof(Gender)).Length);

            switch (person.Gender)
            {
                case Gender.Male:
                    person.FirstName = maleFirstNameList[random.Next
                                      (0, maleFirstNameList.Count)];
                    person.LastName = lastNameList[random.Next
                                     (0, lastNameList.Count)];
                    break;

                case Gender.Female:
                    person.FirstName = femaleFirstNameList[random.Next
                                      (0, femaleFirstNameList.Count)];
                    person.LastName = lastNameList[random.Next
                               (0, lastNameList.Count)] + "а";
                    break;
            }
            //TODO: duplication
            person.Age = random.Next(1, 122);
            return person;
        }

    }
}