using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricTest.BLL.Shapes.Implementations
{
    public class Square:Interfaces.IShape
    {
        /// <inheritdoc cref="Interfaces.IShape.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Interfaces.IShape.CreatedDate"/>
        public DateTime? CreatedDate { get; set; }

        public double SideLength { get; set; }

        public Square()
        {
            this.CreatedDate = DateTime.Now;
        }

        /// <inheritdoc cref="Interfaces.IShape.Perimeter"/>
        public double Perimeter => 4 * SideLength;

        /// <inheritdoc cref="Interfaces.IShape.Area"/>
        public double Area => SideLength * SideLength;
        
    }
}
