using Microsoft.EntityFrameworkCore;

namespace CrudAssignment.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Operation> Operations { get; set; }

        public DbSet<Device> Devices { get; set; }
    }
}
