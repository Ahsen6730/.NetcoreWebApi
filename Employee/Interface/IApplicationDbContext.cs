using Microsoft.EntityFrameworkCore;
using Employee.Models;

namespace Employee.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<EmployeeEntity>? Employee{ get; set; }
        Task<int> SaveChanges();
    }
}
