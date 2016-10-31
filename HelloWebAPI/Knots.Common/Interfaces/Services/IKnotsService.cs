using Knots.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knots.Common.Interfaces.Services
{
    public interface IKnotsService
    {
        IEnumerable<Knot> GetAllKnots();
        Task<Knot> FindKnot(int id);
    }
}
