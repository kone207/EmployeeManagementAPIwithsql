using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName="nvarchar(250)")]
        public string FullName { get; set; }
        public string Contact { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Address Address { get; set; } = new Address { };
    }
}
