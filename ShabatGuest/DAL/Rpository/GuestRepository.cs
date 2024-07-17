using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShabatGuest.DAL;
using ShabatGuest.DAL.Rpository;
using ShabatGuest.DAL.Model;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace ShabatGuest.DAL.Rpository
{
    public class GuestRepository : IRepository<GuestModel>
    {
        DBContext dbContext;

        public GuestRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<GuestModel> GetAll()
        {
            List<GuestModel> guests = new List<GuestModel>();
            string query = "SELECT * FROM Guests";
            DataTable dt = dbContext.ExecuteQuery(query, null);
            foreach (DataRow dr in dt.Rows)
            {
                guests.Add(new GuestModel(dr));
            }
            return guests;
        }

        public GuestModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(GuestModel guest)
        {
            try
            {
                string query = @" IF NOT EXISTS(SELECT 1 FROM Guests WHERE Name = @GuestName)
                                    BEGIN
                                        INSERT INTO Guests(Name)
                                        OUTPUT INSERTED.ID
                                        VALUES(@GuestName);
                                    END
                                ELSE
                                    BEGIN
                                        SELECT ID FROM Guests WHERE Name = @GuestName
                                    END;";
                SqlParameter[] parameters = { new SqlParameter("@GuestName", guest.Name) };

                return (int)dbContext.ExecuteScalar(query, parameters);
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
