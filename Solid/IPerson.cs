using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //LSP - Liskov Substitution Principle
    public interface IPerson
    {
        void Speak();
        void Walk();
        void Sleep();
        void Eat();
        void Run();

    }
}
