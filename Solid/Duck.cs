using System;

namespace Solid
{
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


}
