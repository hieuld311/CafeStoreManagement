using System;
using System.Collections.Generic;
using System.Data;

namespace Project_PRN211.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillInfos = new HashSet<BillInfo>();
        }
        public Bill(int id, DateTime dateCheckin, DateTime? dateCheckOut, int status, int discount = 0, string userInCharge = null )
        {
            this.Id = id;
            this.DateCheckIn = DateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
            this.UserInCharge = userInCharge;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime)row["dateCheckin"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["status"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
            if (row["userInCharge"].ToString() != "")
                this.UserInCharge = (string)row["userInCharge"];
        }
        public int Id { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int IdTable { get; set; }
        public int Status { get; set; }
        public int? Discount { get; set; }
        public double? TotalPrice { get; set; }
        public string? UserInCharge { get; set; }

        public virtual TableFood IdTableNavigation { get; set; } = null!;
        public virtual Account? UserInChargeNavigation { get; set; }
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
