using Microsoft.AspNetCore.Mvc;
using PrometricTest.BLL.Services.Interfaces;
using PrometricTest.BLL.Shapes.Implementations;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapesController : ControllerBase
    {
        private readonly IPersistenceService _persistenceService;
        private readonly IShapeService _shapeService;
        private readonly ILogger<ShapesController> _logger;
        public ShapesController(IPersistenceService persistenceService, IShapeService shapeService, ILogger<ShapesController> logger)
        {
            _persistenceService = persistenceService ?? throw new ArgumentNullException(nameof(persistenceService));
            _shapeService = shapeService ?? throw new ArgumentNullException(nameof(shapeService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost("[action]")]
        public void AddCircle(Circle Shape)
        {
            _logger.Log(LogLevel.Information,"Trying to add a circle");
            this._shapeService.AddShape(Shape);
            _logger.Log(LogLevel.Information, "Circle added");
        }

        [HttpPost("[action]")]
        public void AddRectangle(Rectangle Shape)
        {
            _logger.Log(LogLevel.Information, "Trying to add a Rectangle");
            this._shapeService.AddShape(Shape);
            _logger.Log(LogLevel.Information, "Rectangle added");
        }

        [HttpPost("[action]")]
        public void AddSquare(Square Shape)
        {
            _logger.Log(LogLevel.Information, "Trying to add a Square");
            this._shapeService.AddShape(Shape);
            _logger.Log(LogLevel.Information, "Square added");
        }

        [HttpPost("[action]")]
        public void AddTriangle(Triangle Shape)
        {
            _logger.Log(LogLevel.Information, "Trying to add a Triangle");
            this._shapeService.AddShape(Shape);
            _logger.Log(LogLevel.Information, "Triangle added");
        }

        [HttpGet("[action]")]
        public List<IShape> GetShapesOrderByPerimeter()
        {
            _logger.Log(LogLevel.Information, "Trying to get a list Shapes");
            return this._shapeService.GetShapesSortedByPerimeter();

        }

        [HttpGet("[action]")]
        public List<IShape> GetShapesSortedByArea()
        {
            _logger.Log(LogLevel.Information, "Trying to get a list Shapes");
            return this._shapeService.GetShapesSortedByArea();

        }

        [HttpGet("[action]")]
        public void SaveShapesInCache()
        {
            var shapesToSave = this._shapeService.GetShapesSortedByArea();
            this._persistenceService.Save(shapesToSave);
        }

        [HttpGet("[action]")]
        public dynamic GetMetrics()
        {
            var metrics = this._shapeService.getMetrics();
           return metrics;
        }
    }
}
