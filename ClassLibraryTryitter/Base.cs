using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTryitter
{
    public abstract class Base : IBase
    {
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
        public DateTimeOffset? Deleted { get; set; }

        public static void OnModelCreating<TEntity>(ModelBuilder modelBuilder)
        where TEntity : class, IBase
        {
            modelBuilder.Entity<TEntity>().HasKey(entity => entity.Id);
        }
    }
}
