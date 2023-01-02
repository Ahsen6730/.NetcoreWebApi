using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Employee.Models
{
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
