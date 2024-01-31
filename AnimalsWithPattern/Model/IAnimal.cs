using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public interface IAnimal
    {
        int AnimalId { get; set; }
        string TypeAnimal { get; set; }
        string Name { get; set; }
        string Location { get; set; }
        string Feed { get; set; }
    }
}
