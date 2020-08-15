using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AggregatorMicroService.Models;
using AggregatorMicroService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AggregatorMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IAggregratorService _aggregratorService;

        public OrderDetailsController(IAggregratorService aggregratorService)
        {
            _aggregratorService = aggregratorService;
        }

        [HttpGet("{id:int}")]
        public async Task<Aggregrator> GetAsync(int id)
        {
            return await _aggregratorService.GetUserAndOrderDetailsAsync(id);
        }
    }
}
