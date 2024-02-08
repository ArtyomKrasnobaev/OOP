namespace Persons
{
    public class Person
    {
        private string _firstName;

        private string _lastName;

        private int _age;

        private Gender _gender;

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
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string GetPersonInfo()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, Возраст: {Age}, Пол: {Gender}\n";
        }
    }
}