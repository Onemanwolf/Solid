using System;

namespace Solid
{
    //Interface Segregation Principle
    public class Hunter : IPerson , IHunter
    {
        public void BuildFire()
        {
            throw new NotImplementedException();
        }

        public void Chop()
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

        public void Prep()
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


}
