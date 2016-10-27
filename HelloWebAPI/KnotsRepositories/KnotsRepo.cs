using KnotsInterfaces.Repositories;
using KnotsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnotsRepositories
{
    public class KnotsRepo : IKnotsRepo
    {
        private static List<Knot> DummyList = new List<Knot> { new Knot { Id = 1, Title="Dinner", Content="Make dinner" },
                                                               new Knot { Id = 2, Title="Shopping", Content="Shop for grocery" } };
        
        public IEnumerable<Knot> GetAllKnots()
        {
            return DummyList.ToList();
        }
        
        public async Task<Knot> Find(int id)
        {
            Knot knot = await Task.Run<Knot>(() => { return DummyList.Find(k => k.Id == id); });
            return knot;
        }
    }
}
