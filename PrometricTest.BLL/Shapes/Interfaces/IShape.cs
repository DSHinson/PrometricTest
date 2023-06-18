using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricTest.BLL.Shapes.Interfaces
{
    public interface IShape
    {
        /// <summary>
        /// The name of the shape
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The perimeter of the shape
        /// </summary>
        public double Perimeter { get; }

        /// <summary>
        /// The area of the shape
        /// </summary>
        public double Area { get; }

        /// <summary>
        /// The created date time of the shape
        /// </summary>
        public DateTime? CreatedDate { get; }
    }
}
