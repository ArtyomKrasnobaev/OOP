namespace Persons
{
    public class PersonList
    {
        List<Person> personList = new List<Person>();

        public void AddPerson(Person person)
        {
            personList.Add(person);
        }

        public void RemovePerson(Person person)
        {
            personList.Remove(person);
        }

        public void RemovePersonByIndex(int index)
        {
            personList.RemoveAt(index);
        }

        public Person GetPersonByIndex(int index)
        {
            return personList[index];
        }

        public int GetIndexOfPerson(Person person)
        {
            if (personList.Contains(person))
            {
                return personList.IndexOf(person);
            }
            else
            {
                Console.WriteLine("Элемент отсутствует в списке");
                return -1;
            }
        }

        public void ClearList()
        {
            personList.Clear();
        }

        public int GetLength()
        {
            return personList.Count;
        }

        public string GetPersonListInfo()
        {
            string info = "";
            foreach (Person person in personList)
            {
                info += person.GetPersonInfo();
            }
            return info;
        }
    }
}
