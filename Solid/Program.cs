using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // SPR - Single Responsibility Principle
            var duck = new Duck();
            // OCP - Open Closed Principle
            var hunter = new Hunter();
            LSP(); // LSP - Liskov Substitution Principle
            // ISP - Interface Segregation Principle
            DIP(); // DIP - Dependency Inversion Principle

        }

        private static void DIP()
        {
            var classDependingOnRepo = new ClassDependingOnRepo(new ConcreteRepoA());
            // DIP and LSP in action
            // We see a new implementation of IRepo and the class depending on it does not need to change
            var classDependingOnRepo2 = new ClassDependingOnRepo(new ConcreteRepoB());
            var person1 = new Person { Id = 1, FirstName = "John", LastName = "Oleson", Address = new Address("123 Main St", "New York", "NY", "10001") };

            // HashSet no duplicates allowed
            classDependingOnRepo2.SavePerson(person1);
            classDependingOnRepo2.SavePerson(person1);
            var peopleFromRepo2 = classDependingOnRepo2.GetAllPeople();
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


}
