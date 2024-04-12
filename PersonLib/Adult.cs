using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    /// <summary>
    /// Класс Adult (наследник класса Person).
    /// </summary>
    public class Adult : Person
    {
        /// <summary>
        /// Поле серии паспорта.
        /// </summary>
        private int _passportSeries;

        /// <summary>
        /// Поле номера паспорта.
        /// </summary>
        private int _passportNumber;

        /// <summary>
        /// Поле партнера.
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Поле места работы.
        /// </summary>
        private string _job;

        public override int MinAge { get; } = 18;

        //TODO: validation
        /// <summary>
        /// Свойство для получения доступа к полю _passportSeries.
        /// </summary>
        public int PassportSeries
        {
            get { return _passportSeries; }
            set { _passportSeries = value; }
        }

        //TODO: validation
        /// <summary>
        /// Свойство для получения доступа к полю _passportNumber.
        /// </summary>
        public int PassportNumber
        {
            get { return _passportNumber; }
            set { _passportNumber = value; }
        }

        //TODO: validation
        /// <summary>
        /// Свойство для получения доступа к полю _partner.
        /// </summary>
        public Adult Partner
        {
            get { return _partner; }
            set
            {
                _partner = value;
                if (value != null)
                {
                    value._partner = this;
                }
            }
        }

        //TODO: validation
        /// <summary>
        /// Свойство для получения доступа к полю _job.
        /// </summary>
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public Adult() : this("Неизвестно", "Неизвестно", 18, Gender.Male,
                              0, 0, null, null)
        { }

        /// <summary>
        /// Конструктор класса Adult.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="passportSeries">Серия паспорта.</param>
        /// <param name="passportNumber">Номер паспорта.</param>
        /// <param name="partner">Партнер.</param>
        /// <param name="job">Место работы.</param>
        public Adult(string firstName, string lastName, int age,
                     Gender gender, int passportSeries, int passportNumber,
                     Adult partner, string job)
            : base(firstName, lastName, age, gender)
        {
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Partner = partner;
            Job = job;
        }

        public override string GetInfo()
        {
            string partner = "";
            if (Gender == Gender.Male && Partner == null)
            {
                partner = "не женат";
            }
            if (Gender == Gender.Female && Partner == null)
            {
                partner = "не замужем";
            }
            if (Partner != null)
            {
                partner = Partner.FirstName + " " + Partner.LastName;
            }
            if (Job == null || Job == "")
            {
                Job = "Безработный";
            }

            return base.GetInfo() +
                   $", Паспорт: {PassportSeries} {PassportNumber}," +
                   $" Партнер: {partner}, Место работы: {Job}\n";
        }
    }
}
