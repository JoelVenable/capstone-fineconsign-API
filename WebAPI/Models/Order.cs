using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Order
    {
        public int CustomerID { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public bool IsSubmitted { get; set; }
        public bool IsCancelled { get; set; }

        public int ID { get; set; }

        public DateTime SubmittedTime { get; set; }
        public DateTime ApprovedTime { get; set; }

        public decimal OrderTotal { get; set; }
    }
}
