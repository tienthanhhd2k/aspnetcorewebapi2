using webapi2.Models;
namespace webapi2.Services
{
    public interface IPeople
    {
        public List<PersonModel> GetAll();
        public void Add (PersonModel person);
        public void Update (PersonModel person);
        public void Delete(int Id);
        public List<PersonModel> GetFullName (string FirstName, string LastName, string Gender, string BirthPlace);
        
    }
}
