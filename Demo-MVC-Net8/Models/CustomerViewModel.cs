using System.Collections.Generic;

namespace Demo_MVC_Net8.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";  // Read-only getter concatenating FirstName + space + LastName
        public List<CustomerOrder> Orders { get; set; } = new List<CustomerOrder>();
    }
}