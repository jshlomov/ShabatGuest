using ShabatGuest.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShabatGuest.DAL.Rpository
{
    public class FoodRepository : IFoodRepository
    {
        DBContext dBContext;

        public FoodRepository(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<FoodModel> GetAll()
        {
            List<FoodModel> foods = new List<FoodModel>();
            string query = "SELECT * FROM Food";
            DataTable dt = dBContext.ExecuteQuery(query, null);
            foreach (DataRow dr in dt.Rows)
            {
                foods.Add(new FoodModel(dr));
            }
            return foods;
        }

        public List<FoodWithNameModel> GetAllWithNames(int id, int catId)
        {
            List<FoodWithNameModel> foodWithNames = new List<FoodWithNameModel>();
            string query = @"SELECT g.Name as GuestName, f.Name as FoodName
                            FROM Food f
                            JOIN Guests g
                            ON f.Guest_ID = g.ID
                            WHERE f.Guest_ID != @ID
                            AND f.Category_ID = @catID;";
            DataTable dt = dBContext.ExecuteQuery(query, new SqlParameter[] 
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@CATid", catId)
            });
            foreach (DataRow dr in dt.Rows)
            {
                foodWithNames.Add(new FoodWithNameModel(dr));
            }
            return foodWithNames;
        }

        public FoodModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(FoodModel food, int catId, int gstId)
        {
            try
            {
                string query = @" IF NOT EXISTS(SELECT 1 FROM Food 
				                    WHERE Category_ID = @Category_ID AND
					                      Guest_ID = @Guest_ID AND
					                      Name = @Name)
                                    BEGIN
                                        INSERT INTO Food(Category_ID, Guest_ID, Name)
                                        OUTPUT INSERTED.ID
                                        VALUES(@Category_ID, @Guest_ID, @Name);
                                    END
                                ELSE
                                    BEGIN
                                        SELECT -1;
                                    END;";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Category_ID", catId),
                    new SqlParameter("@Guest_ID", gstId),
                    new SqlParameter("@Name", food.Name)
                };

                return (int)dBContext.ExecuteScalar(query, parameters);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Insert(FoodModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
