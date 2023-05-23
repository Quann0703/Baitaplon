using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DAL_KiemTra
    {
        public DataTable getbaitest()
        {
            string query = $"SP_getbaitest";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public DataTable gettestid(int id)
        {
            string query = $"SP_gettestID @testID ";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                id
            });
        }
    }
}
