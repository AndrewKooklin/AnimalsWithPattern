using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class FileWriter
    {
        public IFileSave Type { get; set; }

        public ModelAnimal _animalsDB { get; set; }

        public FileWriter(IFileSave Method, ModelAnimal animalsDB)
        {
            Type = Method;
            _animalsDB = animalsDB;
        }

        public void Save()
        {
            Type.SaveToFile(_animalsDB);
        }
    }
}
