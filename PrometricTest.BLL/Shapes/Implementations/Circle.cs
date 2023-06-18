using PrometricTest.BLL.Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricTest.BLL.Shapes.Implementations
{
    public class Circle : Interfaces.ICircle
    {
        /// <inheritdoc cref="Interfaces.IShape.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Interfaces.ICircle.Radius"/>
        public double Radius { get; set; }

        /// <inheritdoc cref="Interfaces.IShape.Perimeter"/>
        public double Perimeter => 2 * Math.PI * Radius;

        /// <inheritdoc cref="Interfaces.IShape.Area"/>
        public double Area => Math.PI * Math.Pow(Radius, 2);

        /// <inheritdoc cref="Interfaces.IShape.CreatedDate"/>
        public DateTime? CreatedDate { get; set; }

        

        public Circle()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
