using AggregatorMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroService.Services
{
    public interface IUserService
    {
        public Task<User> GetUserByIdAsync(int userId);
    }
}
