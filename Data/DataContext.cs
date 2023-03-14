using CustomerManagementAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }
        public DbSet<Customer> Customer { get; set; }
    }
}
