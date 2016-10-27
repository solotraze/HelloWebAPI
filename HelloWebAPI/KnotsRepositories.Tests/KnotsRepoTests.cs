using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using NSubstitute;
using KnotsInterfaces.Repositories;
using KnotsModels;

namespace KnotsRepositories.Tests
{
    public class KnotsRepoTests
    {
        public KnotsRepoTests()
        {
            Console.WriteLine("Inside constructor: KnotsRepoTests()");
        }

        [Fact]
        public void GetTest()
        {
            var knotsRepo = new KnotsRepo();
            var knots = knotsRepo.GetAllKnots();

            Assert.NotNull(knots);
            Assert.NotEmpty(knots); // 1 or more
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async Task FindTest(int id)
        {
            var knotsRepo = new KnotsRepo();
            var knot = await knotsRepo.Find(id);

            Assert.NotNull(knot);
            Assert.IsType<Knot>(knot);
            Assert.Equal(knot.Id, id);
        }
    }
}
