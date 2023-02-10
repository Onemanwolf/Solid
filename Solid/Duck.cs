using System;

namespace Solid
{
    //Single Responsibility Principle

    public class Duck : IAnimal , IBird
        {
        public void Walk()
        {
            //Implement Walk behavior here
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

        }

        public void Eat()
        {

        }

        public void Sleep()
        {

        }

        public void Vocalize(string type)
        {

        }

        public void Land()
        {

        }
    }


}
