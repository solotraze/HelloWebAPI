using Knots.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knots.Common.Interfaces.Repos
{
    public interface IKnotsRepo
    {
        IEnumerable<Knot> GetAllKnots();
        Task<Knot> Find(int id);
    }
}
