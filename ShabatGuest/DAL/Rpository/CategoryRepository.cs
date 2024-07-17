using ShabatGuest.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Rpository
{
    public class CategoryRepository : IRepository<CategoryModel>
    {
        DBContext dbContext;

        public CategoryRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<CategoryModel> GetAll()
        {
            try
            {
                List<CategoryModel> categories = new List<CategoryModel>();
                string query = "SELECT * FROM Categories";
                DataTable dt = dbContext.ExecuteQuery(query, null);
                foreach (DataRow dr in dt.Rows)
                {
                    categories.Add(new CategoryModel(dr));
                }
                return categories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CategoryModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
