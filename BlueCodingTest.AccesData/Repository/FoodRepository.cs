using BlueCodingTest.AccesData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueCodingTest.AccesData.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private BlueCodingTestContext _context;

        public FoodRepository(BlueCodingTestContext context)
        {
            _context = context;
        }


        public async Task<IList<Food>> Get()
        {
            return await _context.Food.ToListAsync();
        }

        public async Task<IList<Food>> Get(string type)
        {
            var resp = new List<Food>();
            switch (type)
            {
                case "UpperCase":
                    resp = await _context.Food.Select(x => new Food(){
                        Name = x.Name.ToUpper(),
                        Id = x.Id
                    }).ToListAsync();
                    break;
                case "LowerCase":
                    resp = await _context.Food.Select(x => new Food()
                    {
                        Name = x.Name.ToLower(),
                        Id = x.Id
                    }).ToListAsync();
                    break;
                default:
                    resp = await _context.Food.ToListAsync();
                    break;
            }
            return resp;
        }
    }
}
