using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using NSubstitute;
using KnotsInterfaces.Repositories;

namespace KnotsRepositories.Tests
{
    public class KnotsRepoTests
    {
        public KnotsRepoTests()
        {
            Console.WriteLine("Inside constructor: KnotsRepoTests()");
        }

        [Fact]
        public void GetAllKnotsTest()
        {
            var knotsRepo = new KnotsRepo();//Substitute.For<IKnotsRepo>();
            var knots = knotsRepo.GetAllKnots();

            Assert.NotNull(knots);
            Assert.NotEmpty(knots); // 1 or more
        }
    }
}
