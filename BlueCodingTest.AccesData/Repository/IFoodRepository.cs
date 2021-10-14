using BlueCodingTest.AccesData.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlueCodingTest.AccesData.Repository
{
    public interface IFoodRepository
    {

        public Task<IList<Food>> Get();

        public Task<IList<Food>> Get(string type);
    }
}
