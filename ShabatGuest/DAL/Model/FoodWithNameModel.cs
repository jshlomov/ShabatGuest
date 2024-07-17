using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Model
{
    public class FoodWithNameModel
    {
        public string GuestName { get; set; } 
        public string FoodName { get; set; }

        public FoodWithNameModel(string guestName, string foodName)
        {
            GuestName = guestName;
            FoodName = foodName;
        }

        public FoodWithNameModel(DataRow row)
        {
            if (row == null) throw new ArgumentNullException(nameof(row));
            GuestName = row["GuestName"].ToString();
            FoodName = row["FoodName"].ToString();
        }

    }
}
