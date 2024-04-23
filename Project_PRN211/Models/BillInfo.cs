using System;
using System.Collections.Generic;
using System.Data;

namespace Project_PRN211.Models
{
    public partial class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            this.Id = id;
            this.IdBill = billID;
            this.IdFood = foodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdBill = (int)row["idbill"];
            this.IdFood = (int)row["idfood"];
            this.Count = (int)row["count"];
        }
        public int Id { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }

        public virtual Bill IdBillNavigation { get; set; } = null!;
        public virtual Food IdFoodNavigation { get; set; } = null!;
    }
}
