using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        public bool CanEditInventory { get; set; }
        public bool CanProcessOrders { get; set; }
        public bool CanEditEmployees { get; set; }

        public bool CanEditUsers { get; set; }

    }
}
