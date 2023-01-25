using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal interface PharmacyCrud<P>
    {
        bool Add(P obj);
        bool  Delete(int id);
        P Detail(int id);
        List<P> List();
            
    }
}

