using webapi2.Models;
namespace webapi2.Services
{
    public class PeopleService : IPeople
    {
        public static List<PersonModel> listPerson = new List<PersonModel>
        {
            new PersonModel
            {
                Id = 1,
                FirstName = "Do",
                LastName = "Tien Thanh",
                DateOfBirth = new DateTime(2000,02,13),
                Gender = "Male",
                BirthPlace = "Hai Duong"
            },
            new PersonModel
            {
                Id = 2,
                FirstName = "Do",
                LastName = "Thanh Nam",
                DateOfBirth = new DateTime(1999,02,28),
                Gender = "Male",
                BirthPlace = "Ha Noi"
            },
            new PersonModel
            {
                Id = 3,
                FirstName = "Nguyen",
                LastName = "Tran Tho",
                DateOfBirth = new DateTime(2005,05,20),
                Gender = "Male",
                BirthPlace = "Hai Duong"
            },
            new PersonModel
            {
                Id = 4,
                FirstName = "Tran",
                LastName = "Nam Thanh",
                DateOfBirth = new DateTime(1992,02,13),
                Gender = "Male",
                BirthPlace = "Nam Dinh"
            },
        };
        public List<PersonModel> GetAll(){
            return listPerson;
        }
        public void Add(PersonModel person)
        {
           listPerson.Add(person);
        }

        public void Update(PersonModel person)
        {
            var personUpdate = listPerson.Where(x => x.Id == person.Id).FirstOrDefault();
            personUpdate.Id = person.Id;
            personUpdate.FirstName = person.FirstName;
            personUpdate.LastName = person.LastName;
            personUpdate.DateOfBirth = person.DateOfBirth;
            personUpdate.Gender = person.Gender;
            personUpdate.BirthPlace = person.BirthPlace;
        }
        public void Delete(int Id)
        {
            var personDelete = listPerson.Where(x => x.Id == Id).FirstOrDefault();
            listPerson.Remove(personDelete);
        }
        public List<PersonModel> GetFullName(string FirstName, string LastName, string Gender, string BirthPlace)
        {
          var personFullName = listPerson.Where(x=>x.FirstName==FirstName).Where(p=>p.LastName==LastName).Where(y=>y.Gender==Gender).Where(z=>z.BirthPlace==BirthPlace).ToList(); 
        return personFullName;        
        }    
    }
}