using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    /// <summary>
    /// Класс Child (наследник класса Person).
    /// </summary>
    public class Child : Person
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

        /// <summary>
        /// Свойство для получения доступа к полю _father.
        /// </summary>
        public Adult Father
        {
            get { return _father; }
            set { _father = value; }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _mother.
        /// </summary>
        public Adult Mother
        {
            get { return _mother; }
            set { _mother = value; }
        }

        /// <summary>
        /// Свойство для получения доступа к полю _school.
        /// </summary>
        public string School
        {
            get { return _school; }
            set { _school = value; }
        }

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

        public override string GetInfo()
        {
            string father = "Нет отца";
            string mother = "Нет матери";
            if (Father != null)
            {
                father = Father.FirstName + " " + Father.LastName;
            }
            if (Mother != null)
            {
                mother = Mother.LastName + " " + Mother.FirstName;
            }

            return base.GetInfo() + $"Отец: {Father}, Мать: {Mother}, Школа: {School}";
        }
    }
}
