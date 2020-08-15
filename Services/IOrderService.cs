using AggregatorMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroService.Services
{
    public interface IOrderService
    {
        public Task<List<Order>> GetOrdersByUserIdAsync(int userId);
    }
}
