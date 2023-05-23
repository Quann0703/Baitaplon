using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Baihoc
    {
        public DataTable getmalop()
        {
            string query = $"SP_hienthiMalop";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public DataTable getBaihoc()
        {
            string query = $"SP_hienthiBaihoc";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }

        public void Addbaihoc(DTO_Baihoc baihoc)
        {
            string query = $"SP_AddBaihoc @BaihocID , @LopID , @Tenbaihoc";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                baihoc.mabaihoc,
                baihoc.malop,
                baihoc.tenbaihoc
            });
        }
        public void Editbaihoc(DTO_Baihoc baihoc)
        {
            string query = $"SP_EditBaihoc @BaihocID , @LopID , @Tenbaihoc";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                baihoc.mabaihoc,
                baihoc.malop,
                baihoc.tenbaihoc
            });
        }

        public void deletebaihoc(int mabaihoc)
        {
            string query = $"SP_deletebaihoc @mabaihoc";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                mabaihoc,
            });
        }

        public DataTable getlop_malop(int malop)
        {
            string query = $"SP_selectbaihocml @malop";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                malop
            });
        }
    }
}
