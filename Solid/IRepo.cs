using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //LSP - Liskov Substitution Principle
    public interface IRepo<T>
    {
        void Save(T person);
        void Update(int id, T person);
        void Delete(int id);
        T Get(int id);
        IEnumerable<T> GetAll();

    }
}
