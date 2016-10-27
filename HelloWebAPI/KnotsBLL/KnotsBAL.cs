using KnotsInterfaces.BLL;
using KnotsInterfaces.Repositories;
using KnotsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnotsBLL
{
    public class KnotsBAL : IKnotsBAL
    {
        private readonly IKnotsRepo _repo;

        public KnotsBAL(IKnotsRepo repo)
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
