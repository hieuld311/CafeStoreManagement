using System;
using System.Collections.Generic;
using System.Data;

namespace Project_PRN211.Models
{
    public partial class Food
    {
        public Food()
        {
            BillInfos = new HashSet<BillInfo>();
        }
        public Food(int id, string name, int IdCategory, float price)
        {
            this.Id = id;
            this.Name = name;
            this.IdCategory = IdCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCategory = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdCategory { get; set; }
        public double Price { get; set; }

        public virtual FoodCategory IdCategoryNavigation { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
