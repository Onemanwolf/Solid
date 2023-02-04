using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //Interface Segregation Principle logically grouped 
    public interface IFly
    {

      
        void Glide();
        void Hover();
        void Dive();
    }
}
