using Knots.Common.Interfaces.Repos;
using Knots.Common.Interfaces.Services;
using Knots.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knots.Services
{
    public class KnotsService : IKnotsService
    {
        private readonly IKnotsRepo _repo;

        public KnotsService(IKnotsRepo repo)
        {
            _repo = repo;
        }
        public IEnumerable<Knot> GetAllKnots()
        {
            return _repo.GetAllKnots();
        }

        public async Task<Knot> FindKnot(int id)
        {
            return await _repo.Find(id);
        }
    }
}
