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

        public static Person GetRandomPerson(Gender gender)
        {
            Person person = new();
            person.Gender = gender;
            SetPersonData(person);
            return person;
        }

        public static Adult GetRandomAdult()
        {
            Adult adult = new();
            SetPersonData(adult);
            SetAdultData(adult);
            SetAdultPartner(adult);
            return adult;
        }

        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new();
            adult.Gender = gender;
            SetPersonData(adult);
            SetAdultData(adult);
            SetAdultPartner(adult);
            return adult;
        }

        public static Child GetRandomChild()
        {
            Child child = new();
            SetPersonData(child);
            SetChildData(child);
            return child;
        }
        
        public static void SetAdultPartner(Adult adult)
        {
            Adult partner = new();
            SetPersonData(partner);
            adult.Partner = partner;
            partner.LastName = adult.LastName;
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

            //person.Gender = (Gender)random.Next(Enum.GetValues
            //                         (typeof(Gender)).Length);

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
                "Гимназия 10", "Лицей 5", "МБОУ СОШ 3", "МБОУ СОШ 8",
                "Лицей 1", "Церковно-приходская"
            };
            child.Father = GetRandomAdult(Gender.Male);
            child.Mother = GetRandomAdult(Gender.Female);
            child.Mother.LastName = child.Father.LastName;
            child.School = schoolList[random.Next(0, schoolList.Count)];
        }
    }
}