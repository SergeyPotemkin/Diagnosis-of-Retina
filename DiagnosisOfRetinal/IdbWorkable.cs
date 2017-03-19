using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    interface IdbWorkable<T>
    {
        T read(long id);
        long insert(T obj);
        bool delete(T obj);
        bool delete(int id);
        bool update(T obj);
    }
}
