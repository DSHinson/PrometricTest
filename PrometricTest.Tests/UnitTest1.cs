using Microsoft.Extensions.Caching.Memory;
using PrometricTest.BLL.Services.Implementations;
using PrometricTest.BLL.Services.Interfaces;
using PrometricTest.BLL.Shapes.Implementations;

namespace PrometricTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IMemoryCache testMemoryCache; 
        private IShapeService shapeService;

        public UnitTest1()
        {
            testMemoryCache = new MemoryCache(new MemoryDistributedCacheOptions());
            shapeService = new ShapeService(testMemoryCache);
        }

        [TestMethod]
        public void TestMethod1()
        {
            this.shapeService.AddShape(new Circle()
            {
                Name = "Test"

            });

            Assert.IsTrue(shapeService.GetShapesSortedByArea().Any());
        }
    }
}