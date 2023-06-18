using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Services.Interfaces
{
    public interface IShapeService
    {
        /// <summary>
        /// Returns a list of IShape objects sorted by Perimeter
        /// </summary>
        /// <returns>List&lt;IShape&gt;</returns>
        public List<IShape> GetShapesSortedByPerimeter();

        /// <summary>
        /// Returns a list of IShape objects sorted by Area
        /// </summary>
        /// <returns>List&lt;IShape&gt;</returns>
        public List<IShape> GetShapesSortedByArea();

        /// <summary>
        /// This function will add a shape object to the internal list that will be cached between requests
        /// </summary>
        /// <param name="Shape">Shape object to add to list</param>
        public void AddShape(IShape Shape);

        /// <summary>
        ///  this will return an output of the 
        /// </summary>
        /// <returns>a dynamic object of the metrics of the cache</returns>
        public dynamic getMetrics();
    }
}
