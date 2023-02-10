
using System.Linq;
using System.Collections.Generic;

namespace Solid
{
    //Class Concrete Implementing IRepo
    //DIP - Dependency Inversion Principle
    public class ConcreteRepoA : IRepo<Person>
    {

        public List<Person> People { get; set; } = new List<Person>();
        public void Delete(int id)
        {
            //Implementing code goes here
            var deletePerson = People.FirstOrDefault<Person>(x => x.Id == id);
            People.Remove(deletePerson);

        }

        public Person Get(int id)
        {
            //Implementing code goes here
            var person = People.FirstOrDefault(x => x.Id == id);
            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            return People.ToList();
        }

        public void Save(Person person)
        {
            //Implementing code goes here
            People.Add(person);

        }

        public void Update(int id, Person person)
        {
            //Implementing code goes here
            var updatePerson = People.FirstOrDefault(x => x.Id == id);
            People.Remove(updatePerson);
            People.Add(person);

        }
    }


}
