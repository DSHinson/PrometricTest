using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Shapes.Implementations
{
    public class Rectangle:Interfaces.IShape
    {
        /// <inheritdoc cref="Interfaces.IShape.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Interfaces.IShape.CreatedDate"/>
        public DateTime? CreatedDate { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        /// <inheritdoc cref="IShape.Perimeter"/>
        public double Perimeter => 2 * (Width + Length);

        /// <inheritdoc cref="IShape.Area"/>
        public double Area => Width * Length;

        public Rectangle()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
