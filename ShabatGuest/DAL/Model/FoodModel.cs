using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Model
{
    public  class FoodModel
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int GuestID { get; set; }
        public string Name { get; set; }

        public FoodModel(int categoryID, int guestID, string name)
        {
            CategoryID = categoryID;
            GuestID = guestID;
            Name = name;
        }

        public FoodModel(DataRow row)
        {
            if(row == null) throw new ArgumentNullException(nameof(row));
            ID = (int)row["ID"];
            CategoryID = (int)row["Category_ID"];
            GuestID = (int)row["Guest_ID"];
            Name = row["Name"].ToString();
        }
    }
}
