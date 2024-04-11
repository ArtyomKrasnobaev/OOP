using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PersonLib
{
    public class RandomPerson
    {
        public static Person GetRandomPerson()
        {
            Person person = new();
            SetPersonGender(person);
            SetPersonData(person);
            return person;
        }

        public static Adult GetRandomAdult()
        {
            Adult adult = new Adult();
            SetPersonGender(adult);
            SetPersonData(adult);
            SetAdultData(adult);
            SetAdultPartner(adult);
            return adult;
        }

        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            adult.Gender = gender;
            SetPersonData(adult);
            SetAdultData(adult);
            return adult;
        }

        public static Child GetRandomChild()
        {
            Child child = new Child();
            SetPersonGender(child);
            SetPersonData(child);
            SetChildData(child);
            return child;
        }

        public static void SetAdultPartner(Adult adult)
        {
            Adult partner = new Adult();
            switch (adult.Gender)
            {
                case Gender.Male:
                    partner = GetRandomAdult(Gender.Female);
                    partner.LastName = adult.LastName + 'а';
                    break;
                case Gender.Female:
                    partner = GetRandomAdult(Gender.Male);
                    adult.LastName = partner.LastName + 'а';
                    break;
            }
            adult.Partner = partner;
        }

        public static void SetPersonGender(Person person)
        {
            Random random = new Random();
            person.Gender = (Gender)random.Next(Enum.GetValues
                (typeof(Gender)).Length);
        }

        public static void SetPersonData(Person person)
        {
            Random random = new Random();

            List<string> maleNames = new List<string>()
            {
                "Андрей", "Борис", "Владимир", "Дмитрий", "Михаил",
                "Антон", "Глеб", "Вячеслав", "Егор", "Алексей"
            };

            List<string> femaleNames = new List<string>()
            {
                "Анна", "Елизавета", "Валерия", "Анастасия", "Наталья",
                "Евгения", "Виктория", "Екатерина", "Ангелина", "Вера"
            };

            List<string> lastNames = new List<string>()
            {
                "Иванов", "Алексеев", "Павлов", "Васильев", "Малов",
                "Умаров", "Наумов", "Андреев", "Бобров", "Копцев"
            };

            person.LastName = lastNames[random.Next
                              (0, lastNames.Count)];

            switch (person.Gender)
            {
                case Gender.Male:
                    person.FirstName = maleNames[random.Next
                        (0, maleNames.Count)];
                    break;
                case Gender.Female:
                    person.FirstName = femaleNames[random.Next
                        (0, femaleNames.Count)];
                    person.LastName += "а";
                    break;
            }

            person.Age = random.Next(Person.MinAge, Person.MaxAge);
        }   

        public static void SetAdultData(Adult adult)
        {
            Random random = new Random();
            List<string> jobList = new List<string>()
            {
                "СО ЕЭС", "Россети", "Аэрофлот", "МВД", "ФСБ",
                "РусГидро", "Газпром", "Сбербанк", "РУСАЛ", "Роснефть"
            };

            adult.PassportSeries = random.Next(1000, 9999);
            adult.PassportNumber = random.Next(100000, 999999);
            adult.Job = jobList[random.Next(0, jobList.Count)];
        }

        public static void SetChildData(Child child)
        {
            Random random = new Random();
            List<string> schoolList = new List<string>()
            {
                "Гимназия 10", "Лицей 5", "СОШ 154", "Гимназия 1", 
                "Лицей им. Пушкина", "Церковно-приходская",
                "Физмат лицей 28", "СОШ 228", "Коррекционная"
            };

            child.Father = GetRandomAdult(Gender.Male);
            child.LastName = child.Father.LastName;
            SetAdultPartner(child.Father);
            child.Mother = child.Father.Partner;
            child.School = schoolList[random.Next(0, schoolList.Count)];
        }
    }
}