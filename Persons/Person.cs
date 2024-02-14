using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Persons
{
    public class Person
    {
        private string _firstName;

        private string _lastName;

        private int _age;

        private Gender _gender;

        public Person(): this("Неизвестно", "Неизвестно", 0, Gender.Male)
        { }

        public Person(string firstName, string lastName, int age, Gender gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
        }

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

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string GetPersonInfo()
        {
            return $"Имя: {_firstName}, Фамилия: {LastName}," +
                   $" Возраст: {Age}, Пол: {Gender}\n";
        }

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