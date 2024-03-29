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
        private List<Person> _personList = new List<Person>();

        /// <summary>
        /// Метод добавления объекта в список.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public void AddPerson(Person person)
        {
            _personList.Add(person);
        }

        /// <summary>
        /// Метод удаления объекта из списка.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        public void RemovePerson(Person person)
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
        public Person GetPersonByIndex(int index)
        {
            return _personList[index];
        }

        /// <summary>
        /// Метод получения индекса по объекту.
        /// </summary>
        /// <param name="person">Объект класса Person.</param>
        /// <returns>Индекс объекта.</returns>
        public int GetIndexOfPerson(Person person)
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
        public string GetInfo()
        {
            string info = "";
            foreach (Person person in _personList)
            {
                info += person.GetInfo();
            }

            return info;
        }
    }
}
