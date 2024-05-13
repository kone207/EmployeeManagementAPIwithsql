namespace EmployeeManagementAPI.Models
{
    public class UpdateEmployee
    {
        public string FullName { get; set; }

        public string Contact { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Address Address { get; set; } = new Address();
    }
}
