using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public interface IAnimal
    {
        //string Type { get; set; }

        string Name { get; set; }

        string Location { get; set; }

        string Feed { get; set; }
    }
}
