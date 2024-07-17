using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Model
{
    public class GuestModel
    {
        public int? ID { get; set; } = null;
        public string Name { get; set; }

        public GuestModel(string name)
        {
            Name = name;
        }

        public GuestModel(DataRow row)
        {
            if (row == null && row["Name"] == null)
                throw new System.ArgumentNullException(nameof(row));
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
        }
    }
}
