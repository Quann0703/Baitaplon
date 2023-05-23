using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HS
    {
        public DataTable getHS()
        {
            string query = $"SP_hienthiHS";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public DataTable getusersID()
        {
            string query = $"SP_getUsersIDHS";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public DataTable getlopID()
        {
            string query = $"SP_getLopID";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public void addHS(DTO_HS hs)
        {
            string query = ($"SP_themHS @HS_ID , @users_ID , @HoTen , @NgaySinh , @GioiTinh , @Diachi , @Lop_ID , @SDT , @Email ");
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                hs.HS_ID,
                hs.users__ID,
                hs.Lop_ID,
                hs.HoTen,
                hs.NgaySinh,
                hs.GioiTinh,
                hs.Diachi,
                hs.SDT,
                hs.Email
            });
        }
        public void editHS(DTO_HS hs)
        {
            string query = $"SP_EditHS @HS_ID , @HoTen , @NgaySinh , @Diachi , @Lop_ID , @SDT , @Email ";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                hs.HS_ID,
                hs.HoTen,
                hs.NgaySinh,
                hs.Diachi,
                hs.Lop_ID,
                hs.SDT,
                hs.Email
            });
        }
        public void deleteHS(int mahs)
        {
            string query = $"SP_deleteHS @mahs";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                mahs
            });
        }
        public DataTable seachhs(string key)
        {
            string query = $"SP_seachHS @key";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                key
            });
        }
    }
}
