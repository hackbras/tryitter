using ClassLibraryTryitter;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tryitter.Data
{
    [Table("Team", Schema = "lge")]
    public class Team:Base
    {
        public virtual string Name { get; set; }
        public virtual string ShirtColour { get; set; }
        public virtual string Location { get; set; }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().Property(property => property.Name).HasMaxLength(255);

            modelBuilder.Entity<Team>().Property(property => property.ShirtColour).HasMaxLength(255);

            modelBuilder.Entity<Team>().Property(property => property.Location).HasMaxLength(255);
        }
    }
}
