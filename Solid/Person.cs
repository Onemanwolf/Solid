namespace Solid
{
    public class Person : IPerson
    {


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public void Run()
        {
          //  throw new NotImplementedException();
        }

        public void Sleep()
        {
            //throw new NotImplementedException();
        }

        public void Speak()
        {
            //throw new NotImplementedException();
        }

        public void Walk()
        {
           // throw new NotImplementedException();
        }

        public void Eat()
        {
           // throw new NotImplementedException();
        }
    }



}