using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface IRepo<T>
    {
        void Save();
        void Update(T id);
        void Delete(T id);
        void Get(T id);
        IEnumerable<T> GetAll();

    }
}
