using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class OrderItem
    {
        public bool IsCancelled { get; set; }

        public int OrderID { get; set; }

        public int PaintingID { get; set; }

        public int ID { get; set; }
    }
}
