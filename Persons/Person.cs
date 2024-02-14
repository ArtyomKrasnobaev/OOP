using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Persons
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
        private Gender _gender;

        /// <summary>
        /// Объект класса Person по умолчанию.
        /// </summary>
        public Person(): this("Неизвестно", "Неизвестно", 0, Gender.Male)
        { }

        /// <summary>
        /// Конструктор объекта класса Person.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
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
                if (Regex.IsMatch(value, @"(^[а-яА-Я]+-?[а-яА-Я]+$)") | 
                    Regex.IsMatch(value, @"(^[a-zA-Z]+-?[a-zA-Z]+$)"))
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    _firstName = ti.ToTitleCase(value);
                }
                else
                {
                    throw new Exception("Имя должно содержать только" +
                        " русские или английские символы");
                }
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
                if (Regex.IsMatch(value, @"(^[а-яА-Я]+-?[а-яА-Я]+$)") |
                    Regex.IsMatch(value, @"(^[a-zA-Z]+-?[a-zA-Z]+$)"))
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    _lastName = ti.ToTitleCase(value);
                }
                else
                {
                    throw new Exception("Фамилия должна содержать только" +
                        " русские или английские символы");
                }
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
                if (value < 0)
                {
                    throw new ArgumentException("Возраст должен быть положительным");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _gender
        /// объекта класса Person.
        /// </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        /// Метод получения данных объекта.
        /// </summary>
        /// <returns>Строка с данными полей объекта класса Person.</returns>
        public string GetPersonInfo()
        {
            return $"Имя: {_firstName}, Фамилия: {_lastName}," +
                   $" Возраст: {_age}, Пол: {_gender}\n";
        }

        /// <summary>
        /// Метод генерации случайного объекта класса Person.
        /// </summary>
        /// <returns>Объект класса Person.</returns>
        public static Person GetRandomPerson()
        {
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

            Gender gender = (Gender)random.Next(Enum.GetValues(typeof(Gender)).Length);
            int age = random.Next(0, 100);
            string firstName = "";
            string lastName = "";
            int index = 0;
            if (gender == Gender.Male)
            {
                index = random.Next(0, maleFirstNameList.Count);
                firstName = maleFirstNameList[index];
                lastName = lastNameList[index];
            }

            if (gender == Gender.Female)
            {
                index = random.Next(0, femaleFirstNameList.Count);
                firstName = femaleFirstNameList[index];
                lastName = lastNameList[index] + "а";
            }
            return new Person(firstName, lastName, age, gender);
        }
    }
}