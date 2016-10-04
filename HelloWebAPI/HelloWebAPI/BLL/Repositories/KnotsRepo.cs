using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebAPI.BLL.Repositories
{
    public class KnotsRepo
    {
        private static List<Knot> dummyData = new List<Knot>
        {
            new Knot { KnotId=1, Title="1 Bring Cake", Content="How to make cakes" },
            new Knot { KnotId=2, Title="2 Eat Cake", Content="How much to eat cakes" },
            new Knot { KnotId=3, Title="3 Burn Cake", Content="How to light cakes" },

        };

        public static List<Knot> GetAllKnots()
        {
            return dummyData;
        }

        public static Knot GetKnotById(int id)
        {
            return dummyData.Find(k => k.KnotId == id);
        }

        public static List<Knot> GetKnotsByPhrase(string phrase)
        {
            return dummyData.Where(k => (k.Title.Contains(phrase) || k.Content.Contains(phrase))).ToList();
        }
    }
}