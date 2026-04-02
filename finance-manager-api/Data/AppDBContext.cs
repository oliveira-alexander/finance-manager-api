using finance_manager_api.Category.Entities;
using Microsoft.EntityFrameworkCore;

namespace finance_manager_api.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<CategoryEntity> Categories { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
    }
}
