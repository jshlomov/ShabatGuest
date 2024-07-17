using ShabatGuest.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Rpository
{
    public interface IFoodRepository : IRepository<FoodModel>
    {
        public List<FoodWithNameModel> GetAllWithNames(int id, int catId);
        public int Insert(FoodModel food, int catId, int gstId);
    }
}
