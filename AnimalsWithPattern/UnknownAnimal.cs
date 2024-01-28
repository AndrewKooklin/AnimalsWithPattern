using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    [NotMapped]
    public class UnknownAnimal : Animals, IAnimal
    {
        public UnknownAnimal() : base()
        {

        }

        public UnknownAnimal(int animalId, string typeAnimal, string name, string location, string feed) : base()
        {
            AnimalId = animalId;
            TypeAnimal = typeAnimal;
            Name = name;
            Location = location;
            Feed = feed;
        }

        //public string TypeAnimal { get; set; }
        //public string Name { get; set; }
        //public string Location { get; set; }
        //public string Feed { get; set; }
    }
}
