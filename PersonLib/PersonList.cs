using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    /// <summary>
    /// Класс PersonList.
    /// </summary>
    public class PersonList
    {
        //TODO+: RSDN
        /// <summary>
        /// Список объектов класса Person.
        /// </summary>
        private List<PersonBase> _personList = new List<PersonBase>();

        /// <summary>
        /// Метод добавления объекта в список.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public void AddPerson(PersonBase person)
        {
            _personList.Add(person);
        }

        /// <summary>
        /// Метод удаления объекта из списка.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public void RemovePerson(PersonBase person)
        {
            _personList.Remove(person);
        }

        /// <summary>
        /// Метод удаления объекта из списка по индексу.
        /// </summary>
        /// <param name="index">Индекс объекта.</param>
        public void RemovePersonByIndex(int index)
        {
            _personList.RemoveAt(index);
        }

        /// <summary>
        /// Метод получения объекта в списке по индексу.
        /// </summary>
        /// <param name="index">Индекс объекта.</param>
        /// <returns>Объект класса Person.</returns>
        public PersonBase GetPersonByIndex(int index)
        {
            return _personList[index];
        }

        /// <summary>
        /// Метод получения индекса по объекту.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        /// <returns>Индекс объекта.</returns>
        public int GetIndexOfPerson(PersonBase person)
        {
            if (_personList.Contains(person))
            {
                return _personList.IndexOf(person);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Метод удаления объектов из списка.
        /// </summary>
        public void ClearList()
        {
            _personList.Clear();
        }

        /// <summary>
        /// Метод получения количества объектов списка.
        /// </summary>
        /// <returns>Количество объектов списка.</returns>
        public int GetLength()
        {
            return _personList.Count;
        }

        /// <summary>
        /// Метод получения данных списка.
        /// </summary>
        /// <returns>Строка с данными полей объектов списка.</returns>
        public string GetPersonListInfo()
        {
            string info = "";
            foreach (PersonBase person in _personList)
            {
                info += person.GetInfo();
            }

            return info;
        }
    }
}
