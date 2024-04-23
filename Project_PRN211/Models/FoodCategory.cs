using System;
using System.Collections.Generic;
using System.Data;

namespace Project_PRN211.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }

        public FoodCategory(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public FoodCategory(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Food> Foods { get; set; }
    }
}
