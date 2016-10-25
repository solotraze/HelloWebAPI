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
        private static List<Knot> DummyList = new List<Knot> { new Knot { Title="Dinner", Content="Make dinner" },
                                                               new Knot { Title="Shopping", Content="Shop for grocery" } };
        public IEnumerable<Knot> GetAllKnots()
        {
            return DummyList.ToList();
        }
    }
}
