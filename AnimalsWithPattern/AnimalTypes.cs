using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class AnimalTypes : ObservableCollection<string>
    {
        public AnimalTypes()
        {
            Add("Mammals");
            Add("Birds");
            Add("Amphibians");
            Add("UnknownAnimals");
        }
    }
}
