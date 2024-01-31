using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    [NotMapped]
    public class Bird : Animals, IAnimal
    {
        public Bird() : base()
        {

        }

        public Bird(int animalId, string typeAnimal, string name, string location, string feed) : base()
        {
            AnimalId = animalId;
            TypeAnimal = typeAnimal;
            Name = name;
            Location = location;
            Feed = feed;
        }
    }
}
