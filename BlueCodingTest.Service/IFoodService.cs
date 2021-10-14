using BlueCodingTest.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlueCodingTest.Service
{
    public interface IFoodService
    {
        public Task<IList<FoodDTO>> Get();
        public Task<IList<FoodDTO>> Get(string type);
    }
}
