using KnotsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnotsInterfaces.BLL
{
    public interface IKnotsBAL
    {
        IEnumerable<Knot> GetAllKnots();
    }
}
