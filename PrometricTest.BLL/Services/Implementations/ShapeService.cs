using Microsoft.Extensions.Caching.Memory;
using PrometricTest.BLL.Services.Interfaces;
using PrometricTest.BLL.Shapes.Implementations;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Services.Implementations
{
    public class ShapeService : IShapeService, IDisposable
    {
        private static readonly object _cacheLock = new object();
        private readonly string _cacheKey = "_thisIsTheShapeCacheKey";
        private readonly IMemoryCache _cache;
        protected List<IShape> Shapes { get; set; } = new List<IShape>();
        public ShapeService(IMemoryCache memoryCache)
        {

            _cache = memoryCache ?? throw new ArgumentNullException(nameof(memoryCache));

            if (_cache.TryGetValue(_cacheKey, out List<IShape> shapes))
            {
                this.Shapes = shapes;
            }


        }

        /// <inheritdoc cref="IShapeService.GetShapesSortedByPerimeter"/>
        public List<IShape> GetShapesSortedByPerimeter() => Shapes.SortShapeByPerimeter();

        /// <inheritdoc cref="IShapeService.GetShapesSortedByArea"/>
        public List<IShape> GetShapesSortedByArea() => Shapes.SortShapeByArea();

        ///<inheritdoc cref="IShapeService.AddShape"/>
        public void AddShape(IShape Shape)
        {
            this.Shapes.Add(Shape);
        }

        public dynamic getMetrics()
        {
            var Metric = new
            {
                countofSquares = this.Shapes.Count(x => x.GetType() == typeof(Square)),
                countofTriangles = this.Shapes.Count(x => x.GetType() == typeof(Triangle)),
                countofRectangles = this.Shapes.Count(x => x.GetType() == typeof(Rectangle)),
                countofCircle = this.Shapes.Count(x => x.GetType() == typeof(Circle))
            };
            return Metric;
        }

        private void CacheShapes()
        {
            lock (_cacheLock)
            {
                // Store data in the cache
                MemoryCacheEntryOptions cacheItemPolicy = new MemoryCacheEntryOptions();
                cacheItemPolicy.SetSlidingExpiration(TimeSpan.FromMinutes(1));
                if (_cache.TryGetValue(_cacheKey, out List<IShape> shapes))
                {
                    //This checks if the object has been updated since we created
                    if (shapes != Shapes)
                    {
                        _cache.Set(_cacheKey, shapes, cacheItemPolicy);
                    }
                    else
                    {
                        _cache.Set(_cacheKey, Shapes, cacheItemPolicy);
                    }
                }
                else
                {
                    _cache.Set(_cacheKey, Shapes, cacheItemPolicy);
                }



            }

        }

        public void Dispose()
        {
            CacheShapes();
        }


    }
}
