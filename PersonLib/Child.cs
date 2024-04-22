﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    /// <summary>
    /// Класс Child (наследник класса Person).
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Поле отца.
        /// </summary>
        private Adult _father;
        
        /// <summary>
        /// Поле матери.
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Поле школы.
        /// </summary>
        private string _school;

        /// <inheritdoc/>
        public override int MaxAge { get; } = 17;

        /// <summary>
        /// Свойство для получения доступа к полю _father.
        /// </summary>
        public Adult Father
        {
            get { return _father; }
            set
            {
                if (value is null || value.Gender == Gender.Male)
                {
                    _father = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Отец должен быть мужского пола");
                }
            }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _mother.
        /// </summary>
        public Adult Mother
        {
            get { return _mother; }
            set
            {
                if (value is null || value.Gender == Gender.Female)
                {
                    _mother = value;
                }
                else
                {
                    throw new ArgumentException
                        ("Мать должна быть женского пола");
                }
            }
        }

        /// <summary>
        /// Свойство для получения доступа к полю <see cref="_school"/>
        /// </summary>
        public string School
        {
            get { return _school; }
            set 
            {
                _school = value;
                if (value == null || value == "")
                {
                    _school = "не обучается в школе";
                }
            }
        }

        /// <summary>
        /// Объект класса Child по умолчанию.
        /// </summary>
        public Child() : this("Неизвестно", "Неизвестно", 0, Gender.Male,
            null, null, "")
        { }

        /// <summary>
        /// Конструктор класса Child.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="father">Отец.</param>
        /// <param name="mother">Мать.</param>
        /// <param name="school">Школа.</param>
        public Child(string firstName, string lastName, int age,
                     Gender gender, Adult father,
                     Adult mother, string school)
            : base(firstName, lastName, age, gender)
        {
            Father = father;
            Mother = mother;
            School = school;
        }

        /// <inheritdoc/>
        public override string GetInfo()
        {
            string father = "нет отца";
            string mother = "нет матери";
            if (Father != null)
            {
                father = Father.FirstName + " " + Father.LastName;
            }
            if (Mother != null)
            {
                mother = Mother.FirstName + " " + Mother.LastName;
            }

            return base.GetInfo() + $", Отец: {father}, Мать: {mother}, Школа: {School}\n";
        }

        /// <summary>
        /// Метод для класса Child.
        /// </summary>
        /// <returns></returns>
        public string ComplainAboutSchool()
        {
            return "Жалуется на школу";
        }
    }
}
