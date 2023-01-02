using Microsoft.EntityFrameworkCore;
using Employee.Interface;
using Employee.Models;

namespace Employee.DBContext
{
    public class ApplicationDbContext :DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
                
        }
        public DbSet<EmployeeEntity>? Employee { get; set; }
   
        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }

     
    }
    
}
