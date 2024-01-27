using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class UnknownAnimals : IAnimal
    {
        public UnknownAnimals()
        {
            Name = "Не определено";
            Location = "Не определено";
            Feed = "Не определено";
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Feed { get; set; }
    }
}
