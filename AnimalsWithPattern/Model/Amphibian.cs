using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{   
    [NotMapped]
    public class Amphibian : Animals, IAnimal
    {
        public Amphibian() : base()
        {

        }
        
        public Amphibian(int animalId, string typeAnimal, string name, string location, string feed): base()
        {
            AnimalId = animalId;
            TypeAnimal = typeAnimal;
            Name = name;
            Location = location;
            Feed = feed;
        }
    }
}
