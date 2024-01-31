namespace AnimalsWithPattern
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Serializable]
    [Table("Animals")]
    public partial class Animals : IAnimal
    {
        [Key]
        [Column]
        public int AnimalId { get; set; }

        [Required]
        [StringLength(50)]
        [Column]
        public string TypeAnimal { get; set; }

        [Required]
        [StringLength(50)]
        [Column]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Column]
        public string Location { get; set; }

        [StringLength(50)]
        [Column]
        public string Feed { get; set; }

        public Animals(string typeAnimal, string name, string location, string feed)
        {
            TypeAnimal = typeAnimal;
            Name = name;
            Location = location;
            Feed = feed;
        }

        public Animals()
        {
        }
    }
}
