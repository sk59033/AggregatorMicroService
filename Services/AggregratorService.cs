using AggregatorMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroService.Services
{
    public class AggregratorService : IAggregratorService
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public AggregratorService(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        public async Task<Aggregrator> GetUserAndOrderDetailsAsync(int userId)
        {
            User user = await _userService.GetUserByIdAsync(userId);
            List<Order> orders = await _orderService.GetOrdersByUserIdAsync(userId);


            Aggregrator userAndOrderDetails = new Aggregrator
            {
                 userDetails = user,
                orders = orders
            };

            return userAndOrderDetails;
        }
    }
}
