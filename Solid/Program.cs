using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

    //Class Implementing Repo
    public class ConcreteRepo : IRepo<int>
    {
        public void Delete(int id)
        {
            //Implementing code goes here 
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            //Implementing code goes here 
            throw new NotImplementedException();
        }

        public IEnumerable<int> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            //Implementing code goes here 
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            //Implementing code goes here 
            throw new NotImplementedException();
        }
    }




    //Liskov Substitution Principle
    public class ClassDependingOnRepo
    {
        private IRepo<int> _repo;

        //Dependence are provided by external source thru dependency injection 
        public ClassDependingOnRepo(IRepo<int> repo)
        {
            _repo = repo;
        }
    }


}
