﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonLib
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
        /// Константа минимально допустимого возраста.
        /// </summary>
        private const int _minAge = 1;

        /// <summary>
        /// Константа максимально допустимого возраста.
        /// </summary>
        private const int _maxAge = 120;

        //TODO+: RSDN
        /// <summary>
        /// Константа паттерна русского языка.
        /// </summary>
        private const string _russianPattern = @"(^[а-яА-Я]+-?[а-яА-Я]+$)";

        //TODO+: RSDN
        /// <summary>
        /// Константа паттерна английского языка.
        /// </summary>
        private const string _englishPattern = @"(^[a-zA-Z]+-?[a-zA-Z]+$)";

        /// <summary>
        /// Объект класса Person по умолчанию.
        /// </summary>
        public Person() : this("Неизвестно", "Неизвестно", _minAge, Gender.Male)
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
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
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
                if (IsLanguageSame(FirstName, value))
                {
                    _lastName = VerifyName(value);
                }
                else
                {
                    throw new InvalidOperationException
                        ("Имя и фамилия должны быть написаны" +
                        " на одном языке и не содержать символов");
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
                if (value < _minAge || value > _maxAge)
                {
                    throw new ArgumentOutOfRangeException("Введите возраст" +
                        $" в диапазоне от {_minAge} до {_maxAge}");
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
        public string GetInfo()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}," +
                   $" Возраст: {Age}, Пол: {Gender}\n";
        }

        /// <summary>
        /// Метод проверки правильности и преобразования имен и фамилий.
        /// </summary>
        /// <param name="name">Строка.</param>
        /// <returns>Преобразованная строка.</returns>
        /// <exception cref="Exception">Исключение.</exception>
        public string VerifyName(string name)
        {
            string verifiedName = "";
            if (Regex.IsMatch(name, _russianPattern) ||
                Regex.IsMatch(name, _englishPattern))
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                return verifiedName = textInfo.ToTitleCase(name);
            }

            else
            {
                throw new ArgumentException("Имя и фамилия должны " +
                    "содержать только русские или английские символы");
            }
        }

        /// <summary>
        /// Метод проверки совпадений языков имени и фамилии.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <returns></returns>
        public bool IsLanguageSame(string firstName, string lastName)
        {
            return (Regex.IsMatch(firstName, _russianPattern) && 
                    Regex.IsMatch(lastName, _russianPattern)) || 
                   (Regex.IsMatch(firstName, _englishPattern) &&
                    Regex.IsMatch(lastName, _englishPattern));
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

            person.LastName = lastNameList[random.Next
                              (0, lastNameList.Count)];

            switch (person.Gender)
            {
                case Gender.Male:
                    person.FirstName = maleFirstNameList[random.Next
                                       (0, maleFirstNameList.Count)];
                    break;

                case Gender.Female:
                    person.FirstName = femaleFirstNameList[random.Next
                                       (0, femaleFirstNameList.Count)];
                    person.LastName += "а";
                    break;
            }

            person.Age = random.Next(_minAge, _maxAge);
            return person;
        }
    }
}