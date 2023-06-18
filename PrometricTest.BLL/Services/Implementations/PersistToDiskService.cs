using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrometricTest.BLL.Services.Interfaces;
using PrometricTest.BLL.Shapes.Interfaces;

namespace PrometricTest.BLL.Services.Implementations
{
    public class PersistToDiskService : IPersistenceService
    {
        public void Save(List<IShape> shapesToSave)
        {
           string serializedObj = Newtonsoft.Json.JsonConvert.SerializeObject(shapesToSave);
           string path = Path.Combine(Environment.CurrentDirectory, @"Data\", DateTime.Now.ToString("yy-MM-dd_hh-mm-ss")+".json");
           File.AppendAllLines(path, new[] { serializedObj });
        }
    }
}
