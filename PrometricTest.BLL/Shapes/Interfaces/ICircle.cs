using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricTest.BLL.Shapes.Interfaces
{
    public interface ICircle:IShape
    {
        /// <summary>
        /// The Radius of the shape
        /// </summary>
        public double Radius { get; set; }
    }
}
