using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Taikhoan
    {
        DAL_Taikhoan tk = new DAL_Taikhoan();
        public DataTable GetTK(string usersName, string password, string roles)
        {
            return tk.GetTK(usersName, password, roles);
        }

        public bool kiemtratk(string usersName, string password, string roles)
        {
            return GetTK(usersName, password, roles).Rows.Count > 0;
        }
    }
}
