using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public interface IFileSave
    {
        void SaveToFile(ModelAnimal _animalsDB);
    }
}
