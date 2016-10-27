using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using NSubstitute;
using CoreWeb.Controllers;
using KnotsInterfaces.BLL;
using KnotsInterfaces.Repositories;
using KnotsModels;

namespace CoreWeb.Tests.Controllers
{
    public class KnotsControllerTests
    {
        public KnotsControllerTests()
        {
            Console.WriteLine("Inside constructor: KnotsControllerTests()");
        }

        [Fact]
        public void TestGet()
        {

            //var knotsRepoMock = Substitute.For<IKnotsRepo>();
            var knotsBalMock = Substitute.For<IKnotsBAL>();
            knotsBalMock.GetAllKnots().Returns(new List<Knot> {
                                                new Knot { Title="Mock1", Content="Mock content1" } });
            var controller = new KnotsController(knotsBalMock);
            var result = controller.Get();
            Assert.NotNull(result);
            Assert.Equal(result.Count(), 1);
        }
    }
}
