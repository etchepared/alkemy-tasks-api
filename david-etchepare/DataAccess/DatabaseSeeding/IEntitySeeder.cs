using Microsoft.EntityFrameworkCore;

namespace david_etchepare.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}
