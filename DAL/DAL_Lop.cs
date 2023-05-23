using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Lop
    {
        public DataTable getLop()
        {
            string query = $"SP_hienthiLop";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }

        public DataTable getGVID()
        {
            string query = $"SP_getGVID";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }

        public void addLop(DTO_Lop lop)
        {
            string query = ($"SP_themLop @LopID , @tenlop , @magvcn , @namhoc ");
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                lop.maLop,
                lop.tenlop,
                lop.magvcn,
                lop.namhoc,
            });
        }
        public void editLop(DTO_Lop lop)
        {
            string query = $"SP_EditLop @LopID , @tenlop , @magvcn , @namhoc ";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
               lop.maLop,
                lop.tenlop,
                lop.magvcn,
                lop.namhoc,
            });
        }

        public void deletelop(int malop)
        {
            string query = $"SP_deleteLop @malop";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                malop,
            });
        }
        public DataTable seachLop(string key)
        {
            string query = $"SP_seachLop @key";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                key
            });
        }
    }
}
