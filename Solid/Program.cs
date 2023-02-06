
using System.Linq;
using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DIP();
            LSP();

        }

        private static void DIP()
        {
            var classDependingOnRepo = new ClassDependingOnRepo(new ConcreteRepo());
            // DIP and LSP in action
            var classDependingOnRepo2 = new ClassDependingOnRepo(new ConcreteRepoB());
            var person1 = new Person { Id = 1, FirstName = "John", LastName = "Oleson", Address = new Address("123 Main St", "New York", "NY", "10001") };

             // HashSet no duplicates allowed
             classDependingOnRepo2.SavePerson(person1);
             classDependingOnRepo2.SavePerson(person1);
             var peopleFromRepo2 =   classDependingOnRepo2.GetAllPeople();
            foreach (var person in peopleFromRepo2)
            {
                Console.WriteLine($" From HashSet: {person.FirstName}");
            }


            classDependingOnRepo.SavePerson(person1);
            var people = classDependingOnRepo.GetAllPeople();
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            var selectPerson = classDependingOnRepo.GetPerson(1);
            Console.WriteLine($"Get Person with Id: {selectPerson.Id} Person Name: {selectPerson.FirstName}");
        }

        private static void LSP()
        {
            //LSP - Liskov Substitution Principle
            var a = new A();

            var resutl = a.BehaviorMethod();
            Console.WriteLine(resutl);
            Console.WriteLine(a.PropertyA);

            var b = a.FactoryMethod();
            Console.WriteLine(b.BehaviorMethod());
            Console.WriteLine(b.PropertyB);
        }
    }

    //Class Concrete Implementing IRepo
    //DIP - Dependency Inversion Principle
    public class ConcreteRepo : IRepo<Person>
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

//LSP Liskvo Substition Prinicple
 public class ConcreteRepoB : IRepo<Person>
    {

        public HashSet<Person> People { get; set; } = new HashSet<Person>();
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
