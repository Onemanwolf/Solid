namespace Solid
{
    //LSP - Liskov Substitution Principle
    public abstract class Base<T>
    {
        public abstract T FactoryMethod();
        public abstract bool BehaviorMethod();


    }
}