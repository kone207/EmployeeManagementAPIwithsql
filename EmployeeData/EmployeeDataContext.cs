using EmployeeManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.EmployeeData
{
    public class EmployeeDataContext :DbContext
    {
        public EmployeeDataContext(DbContextOptions options):base(options)
        {

        }
        //add-migration v1 -Context EmployeeDataContext
        //
        public DbSet<Employee> EmployeeTable { get; set; }
        public DbSet<Address> AddressTable { get; set; }
    }
    
}
