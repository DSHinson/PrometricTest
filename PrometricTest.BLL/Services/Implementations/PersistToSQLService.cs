using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrometricTest.BLL.Services.Interfaces;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Services.Implementations
{
    public class PersistToSQLService : IPersistenceService
    {
        public void Save(List<IShape> shapesToSave)
        {
            //this is just here as an example
            throw new NotImplementedException();
        }
    }
}
