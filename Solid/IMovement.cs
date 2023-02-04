using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{

    //Interface Segregation Principle
    public interface IMovement
    {
        void Walk();
        void Run();
    }
}
