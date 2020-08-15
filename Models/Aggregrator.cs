using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroService.Models
{
    public class Aggregrator
    {
        public User userDetails { get; set; }
        public List<Order> orders { get; set; }
    }
}
