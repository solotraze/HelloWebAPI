using KnotsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnotsInterfaces.Repositories
{
    public interface IKnotsRepo
    {
        IEnumerable<Knot> GetAllKnots();
        Task<Knot> Find(int id);
    }
}
