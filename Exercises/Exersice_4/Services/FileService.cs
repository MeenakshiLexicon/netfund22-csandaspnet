using Exersice_4.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_4.Services
{
    internal class FileService
    {
        public void SaveToFile(string fileName, List<Product> productCatalog)
        {
            using (var sw = new StreamWriter(fileName))
            {
                sw.WriteLine(JsonConvert.SerializeObject(productCatalog));
            }
        }

        public IEnumerable<Product> ReadFromFile(string fileName)
        {
            var list = new List<Product>();

            try
            {
                using (var sr = new StreamReader(fileName))
                {
                    var json = sr.ReadToEnd();
                    list = JsonConvert.DeserializeObject<List<Product>>(json);
                }
            }
            catch { }

            return list;
        }
    }
}
