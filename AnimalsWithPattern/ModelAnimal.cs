namespace AnimalsWithPattern
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelAnimal : DbContext
    {
        public ModelAnimal()
            : base("name=ModelAnimalDb")
        {
        }

        public virtual DbSet<Animals> Animals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animals>()
                .Property(e => e.TypeAnimal)
                .IsUnicode(false);

            modelBuilder.Entity<Animals>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Animals>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Animals>()
                .Property(e => e.Feed)
                .IsUnicode(false);
        }
    }
}
