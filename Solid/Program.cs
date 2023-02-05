
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
            var classDependingOnRepo = new ClassDependingOnRepo(new ConcreteRepo());
            var person1 = new Person { Id = 1, FirstName = "John", LastName = "Oleson", Address = new Address("123 Main St","New York","NY","10001") };

            classDependingOnRepo.SavePerson(person1);
            var people =  classDependingOnRepo.GetAllPeople();
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            var selectPerson = classDependingOnRepo.GetPerson(1);
            Console.WriteLine($"Get Person with Id: {selectPerson.Id} Person Name: {selectPerson.FirstName}");

        }
    }



    //Single Responsibility Principle

    public class Duck : IAnimal , IBird
        {
        public void Walk()
        {

        }


        public void Swim()
        {

        }

        public void Fly()
        {

        }



        /// <summary>
        /// Breaks SRP!!!! Ducks don't hunt themselves
        /// </summary>
        public void Hunt()
        {

        }

        /// <summary>
        /// Breask SRP!!! Ducks don't cook themselves
        /// </summary>
        public void Cook()
        {

        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Vocalize(string type)
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }
    }

    //Interface Segregation Principle
    public class Hunter : IPerson , IHunter
    {
        public void BuildFire()
        {
            throw new NotImplementedException();
        }

        public void Cook()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Hunt()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Speak()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }

    //Class Implementing IRepo
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




    //Liskov Substitution Principle
    public class ClassDependingOnRepo
    {
        private IRepo<Person> _repo;

        //Dependence are provided by external source thru dependency injection
        public ClassDependingOnRepo(IRepo<Person> repo)
        {
            _repo = repo;
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
