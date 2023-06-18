using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Services.Interfaces
{
    public interface IPersistenceService
    {
        public void Save(List<IShape> shapesToSave);
    }
}
