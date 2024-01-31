using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class SaveToJSON : IFileSave
    {
        private string _nameFile;

        public SaveToJSON(string nameFile)
        {
            _nameFile = nameFile;
        }

        public void SaveToFile(ModelAnimal _animalsDB)
        {

        }
    }
}
