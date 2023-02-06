namespace Solid
{
    public class B : Base<A>
    {

         public string PropertyB { get; set; }
        public override A FactoryMethod()
        {
          return new A();
        }

        public override bool BehaviorMethod()
        {
            PropertyB = "B";
            return false;
        }
    }

}