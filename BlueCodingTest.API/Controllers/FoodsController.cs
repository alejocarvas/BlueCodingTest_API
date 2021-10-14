using BlueCodingTest.DTO.DTO;
using BlueCodingTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCodingTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private IFoodService _service;

        public FoodsController(IFoodService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<FoodDTO>> Get()
        {
            return await _service.Get();
        }

        [HttpGet("{type}")]
        public async Task<IEnumerable<FoodDTO>> Get(string type)
        {
            return await _service.Get(type);
        }
    }
}
