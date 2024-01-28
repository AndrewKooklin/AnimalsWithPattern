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
                case "Mammals": return new Mammal(0,TypeAnimal, Name, Location, Feed);
                case "Birds": return new Bird(0, TypeAnimal, Name, Location, Feed);
                case "Amphibians": return new Amphibian(0, TypeAnimal, Name, Location, Feed);
                default: return new UnknownAnimal(0, "UnknownAnimal", Name, Location, Feed);
            }
        }
    }
}
