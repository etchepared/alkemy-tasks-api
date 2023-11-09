using Microsoft.EntityFrameworkCore;
using david_etchepare.DataAccess.DatabaseSeeding;
using david_etchepare.Entities;


namespace david_etchepare.DataAccess
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
            
        }   
        
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
            {
                new TareaSeeder()
            };

            foreach (var seeder in seeders)
            {
                seeder.SeedDatabase(modelBuilder);   
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
