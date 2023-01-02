using Microsoft.EntityFrameworkCore;
using Employee.Models;

namespace Employee.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<EmployeeEntity>? Employee{ get; set; }
        DbSet<UserInfoEntity>? UserInfoEntities { get; set; }

        Task<int> SaveChanges();
    }
}
