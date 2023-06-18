using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricTest.BLL.Shapes.Implementations
{
    public class Triangle : Interfaces.IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        /// <inheritdoc cref="Interfaces.IShape.CreatedDate"/>
        public DateTime? CreatedDate { get; set; }

        /// <inheritdoc cref="Interfaces.IShape.Name"/>
        public string Name { get; set; }

        /// <inheritdoc cref="Interfaces.IShape.Perimeter"/>
        public double Perimeter => SideA + SideB + SideC;

        public Triangle()
        {
            this.CreatedDate = DateTime.Now;
        }

        /// <inheritdoc cref="Interfaces.IShape.Area"/>
        public double Area
        {
            get
            {
                // Calculate the semi-perimeter of the triangle
                double semiPerimeter = Perimeter / 2;

                // Calculate the area using Heron's formula
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));

                return area;
            }
        }

        
    }
}
