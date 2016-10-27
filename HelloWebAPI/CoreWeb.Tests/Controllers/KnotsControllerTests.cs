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
using Microsoft.AspNetCore.Mvc;

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
            var knotsBalMock = Substitute.For<IKnotsBAL>();
            knotsBalMock.GetAllKnots().Returns(new List<Knot> {
                                                new Knot { Id = 1, Title="Mock1", Content="Mock content1" } });
            var controller = new KnotsController(knotsBalMock);
            var result = controller.Get();

            Assert.IsNotType<BadRequestResult>(result);
            Assert.IsType<OkObjectResult>(result);

            var contentResult = result as OkObjectResult;
            Assert.IsAssignableFrom<IEnumerable<Knot>>(contentResult.Value);

            var knots = contentResult.Value as IEnumerable<Knot>;
            Assert.NotEmpty(knots);
            Assert.Equal(knots.Count(), 1);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async Task FindTest(int id)
        {
            var knotsBalMock = Substitute.For<IKnotsBAL>();
            knotsBalMock.FindKnot(id).Returns(new Knot { Id = id, Title="Mock1", Content="Mock content1" });
            var controller = new KnotsController(knotsBalMock);

            var result = await controller.Get(id);

            Assert.IsNotType<BadRequestResult>(result);
            Assert.IsType<OkObjectResult>(result);

            var contentResult = result as OkObjectResult;
            Assert.IsType<Knot>(contentResult.Value);

            var knot = contentResult.Value as Knot;
            Assert.NotNull(knot);
            Assert.Equal(knot.Id, id);
        }

        [Fact]
        public void TestPost()
        {
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestPut()
        {
            Assert.True(false, "Not implemented");
        }

        [Fact]
        public void TestDelete()
        {
            Assert.True(false, "Not implemented");
        }
    }
}
