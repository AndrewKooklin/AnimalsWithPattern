using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithPattern
{
    public class Birds : IAnimal
    {
        public Birds()
        {

        }

        public Birds(string name, string location, string feed)
        {
            Name = name;
            Location = location;
            Feed = feed;
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Feed { get; set; }
    }
}
