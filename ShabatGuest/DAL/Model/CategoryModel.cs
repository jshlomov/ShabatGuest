using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.DAL.Model
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CategoryModel(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public CategoryModel(DataRow row)
        {
            if (row == null && row["Name"] == null)
                throw new System.ArgumentNullException(nameof(row));
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
        }
    }
}
