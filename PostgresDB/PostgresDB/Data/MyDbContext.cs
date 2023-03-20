using Microsoft.EntityFrameworkCore;

namespace PostgresDB.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Models.ConPg> MyModels { get; set; }
    }
}
