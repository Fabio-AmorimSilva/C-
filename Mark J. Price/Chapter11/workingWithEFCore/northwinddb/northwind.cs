using Microsoft.EntityFrameworkCore;

namespace northwinddb
{
    // this manages the connection to the database
    public class northwind : DbContext
    {
        // these properties map to tables in the database
        public DbSet<category> categories{get; set;}
        public DbSet<product> products{get; set;}

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder){
                string path = System.IO.Path.Combine(
                    System.Environment.CurrentDirectory, "northwind.db"
                );

                optionsBuilder.UseSqlite($"Filename={path}");
            }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder
        ){
            // example of using Fluent API insted of attributes
            // to limit the length of a category name to 15
            modelBuilder.Entity<category>()
            .Property(category => category.categoryName)
            .IsRequired() //NOT NULL
            .HasMaxLength(15); 

            //global filter to remove discontinued products
            modelBuilder.Entity<product>().HasQueryFilter(p => !p.discontinued);
            
        }

    }
}