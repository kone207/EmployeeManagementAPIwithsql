using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementAPI.Models
{
    public class Address
    {
        [Key]
        public int id { get; set; }
        public string Street { get; set; }
        public string Surbub { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
    }

}
