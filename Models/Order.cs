using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroService.Models
{
    public class Order
    {
        //public long UserId { get; set; }
        public long OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
