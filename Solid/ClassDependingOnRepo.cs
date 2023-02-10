using System.Collections.Generic;

namespace Solid
{
    //Liskov Substitution Principle
    //DIP - Dependency Inversion Principle
    public class ClassDependingOnRepo
    {
        private IRepo<Person> _repo;

        //Dependence are provided by external source thru dependency injection
        public ClassDependingOnRepo(IRepo<Person> repo)
        {
            _repo = repo;
            // new is glue tighly coupling the class to the concrete implementation
            // _repo = new ConcreteRepo();
        }

        public void SavePerson(Person person)
        {
            _repo.Save(person);


        }

        public void UpdatePerson(int id, Person person)
        {
            _repo.Update(id, person);
        }

        public void DeletePerson(int id)
        {
            _repo.Delete(id);
        }

        public Person GetPerson(int id)
        {
            return _repo.Get(id);
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _repo.GetAll();
        }
    }


}
