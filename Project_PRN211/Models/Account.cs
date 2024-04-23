using System;
using System.Collections.Generic;
using System.Data;

namespace Project_PRN211.Models
{
    public partial class Account
    {
        public Account()
        {
            Bills = new HashSet<Bill>();
        }
        public Account(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.PassWord = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];
            this.PassWord = row["password"].ToString();
        }


        public string UserName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public int Type { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
