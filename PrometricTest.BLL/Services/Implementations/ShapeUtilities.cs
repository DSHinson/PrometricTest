using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Services.Implementations
{
    public static class ShapeUtilities
    {
        /// <summary>
        /// This function will sort the shapes collection by Area value
        /// </summary>
        /// <param name="shapes">The shape collection to sort</param>
        public static List<IShape> SortShapeByArea(this List<IShape> shapes)
        {
            // Sort the shapes by Area
            return shapes.OrderBy(x => x.Perimeter).ToList();
        }

        /// <summary>
        /// This function will sort the shapes collection by Perimeter value
        /// </summary>
        /// <param name="shapes">The shape collection to sort</param>
        public static List<IShape> SortShapeByPerimeter(this List<IShape> shapes)
        {
            var test = shapes.OrderBy(x => x.Perimeter).ToList();
            // Sort the shapes by perimeter
            return test;
        }
    }
}
