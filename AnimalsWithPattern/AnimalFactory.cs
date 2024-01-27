using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class AnimalFactory
    {
        public IAnimal GetAnimal(string TypeAnimal,
                                 string Name,
                                 string Location,
                                 string Feed)
        {
            switch (TypeAnimal)
            {
                case "Млекопитающиеся": return new Mammals(Name, Location, Feed);
                case "Птицы": return new Birds(Name, Location, Feed);
                case "Земноводные": return new Amphibians(Name, Location, Feed);
                default: return new UnknownAnimals();
            }
        }
    }
}
