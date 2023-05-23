using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Taikhoan
    {
        DTO_Taikhoan tk = new DTO_Taikhoan();
        public DataTable GetTK(string usersName,string password,string roles)
        {
            string query = $"select * from Users where usersName = N'{usersName}' and password= N'{password}' and roles= N'{roles}'";
            DataTable data = DAL__dataprovider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
