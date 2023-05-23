using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GV
    {
        public DataTable getGV()
        {
            string query = $"SP_hienthiGV";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        
        public DataTable getusersID()
        {
            string query = $"SP_getUsersIDGV";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
       
        public void addGV(DTO_GV gv)
        {
            string query = ($"SP_themGV @GV_ID , @users_ID , @HoTen , @NgaySinh , @GioiTinh , @Diachi , @SDT , @Trinhdo , @Email");
            DAL__dataprovider.Instance.ExecuteQuery(query,new object[]
            {
                gv.GVID,
                gv.users__ID,
                gv.HoTen,
                gv.NgaySinh,
                gv.GioiTinh,
                gv.Diachi,
                gv.SDT,
                gv.TrinhDo,
                gv.Email
            });
        }
        public void editGV(DTO_GV giaovien)
        {
            string query = $"SP_EditGV @GV_ID , @HoTen , @NgaySinh , @Diachi , @SDT , @Trinhdo , @Email ";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                giaovien.GVID,
                giaovien.HoTen,
                giaovien.NgaySinh,
                giaovien.Diachi,
                giaovien.SDT,
                giaovien.TrinhDo,
                giaovien.Email,
            });
        }
        public void deleteGV(int magv)
        {
            string query = $"SP_deleteGV @magv ";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                magv
            });
        }
        public DataTable seachgv(string key)
        {
            string query = $"SP_seach @key";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                key
            });
        }
    }
}
