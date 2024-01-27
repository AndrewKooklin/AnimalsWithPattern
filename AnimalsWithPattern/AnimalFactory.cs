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
                case "Mammals": return new Mammals(Name, Location, Feed);
                case "Birds": return new Birds(Name, Location, Feed);
                case "Amphibians": return new Amphibians(Name, Location, Feed);
                default: return null;
            }
        }
    }
}
