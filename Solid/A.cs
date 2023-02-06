namespace Solid
{
    public class A : Base<B>
    {
        public string PropertyA { get; set; }
        public override B FactoryMethod()
        {
            return new B();
        }

        public override bool BehaviorMethod()
        {
            PropertyA = "A";
            return true;
        }
    }

}