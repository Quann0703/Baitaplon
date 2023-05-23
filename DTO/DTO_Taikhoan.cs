using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;

namespace DTO
{
    public class DTO_Taikhoan
    {
        public string usersName { get; set; }
        public string password { get; set; }

        public string roles { get; set; }

        public DTO_Taikhoan() { }
        public DTO_Taikhoan(string usersName, string password, string roles)
        {
            this.usersName = usersName;
            this.password = password;
            this.roles = roles;
        }
        public DTO_Taikhoan(DataRow row)
        {
            this.usersName = row["usersName"].ToString();
            this.password = row["password"].ToString();
            this.roles = row["roles"].ToString();
        }
    }
}
