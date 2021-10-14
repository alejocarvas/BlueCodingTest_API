using BlueCodingTest.AccesData.Repository;
using BlueCodingTest.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BlueCodingTest.Service
{
    public class FoodService : IFoodService
    {
        private IFoodRepository _repo;

        public FoodService(IFoodRepository repo)
        {
            _repo = repo;
        }

        public async Task<IList<FoodDTO>> Get()
        {
            var resp = await _repo.Get();
            return resp.ToList().Select(x => new FoodDTO()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public async Task<IList<FoodDTO>> Get(string type)
        {
            var resp = await _repo.Get(type);
            return resp.ToList().Select(x => new FoodDTO()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
