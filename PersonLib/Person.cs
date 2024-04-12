using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonLib
{
    //TODO: RSDN, abstract
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

        public virtual int MinAge { get; } = 0;

        public virtual int MaxAge { get; } = 120;

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
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentOutOfRangeException("Введите возраст" +
                        $" в диапазоне от {MinAge} до {MaxAge}");
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
        public virtual string GetInfo()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}," +
                   $" Возраст: {Age}, Пол: {Gender}";
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
            if (Regex.IsMatch(name, @"(^[а-яА-Я]+-?[а-яА-Я]+$)") ||
                Regex.IsMatch(name, @"(^[a-zA-Z]+-?[a-zA-Z]+$)"))
            {
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                return verifiedName = ti.ToTitleCase(name);
            }
            else
            {
                throw new ArgumentException("Имя и фамилия должны содержать " +
                    "только русские или английские символы");
            }
        }
    }
}
