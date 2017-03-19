using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class DbContextInfo
    {
        private static DOR_dbEntities context = new DOR_dbEntities();

        public static DOR_dbEntities getContext()
        {
            return context;
        }
    }
}
