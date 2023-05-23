using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CauHoi
    {
        public DataTable getTestID()
        {
            string query = $"SP_getTestID";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public DataTable getcauhoi(string key)
        {
            string query = $"SP_hienthicauhoi @testID";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                key
            });
        }
        public DataTable gettestid(int id)
        {
            string query = $"SP_getcauhoitestID @testID ";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                id
            });
        }
        public DataTable hienthicauhoi()
        {
            string query = $"SP_gethienthicauhoi";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }

        public DataTable laycauhoi(int testid,int cauhoiid)
        {
            string query = $"SP_laycauhoi @testID , @cauhoiid";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                testid, cauhoiid
            });
        }


        public void addCauhoi(DTO_CauHoi cauhoi)
        {
            string query = $"SP_themCauhoi @cauhoi_id , @TestID , @Baitoan , @dapan1 , @dapan2 , @dapan3 , @dapan4 , @dapan ";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                cauhoi.cauhoiID,
                cauhoi.testID,
                cauhoi.baitoan,
                cauhoi.dapan1,
                cauhoi.dapan2,
                cauhoi.dapan3,
                cauhoi.dapan4,
                cauhoi.dapan
            });
        }
        public void editcauhoi(DTO_CauHoi cauhoi)
        {
            string query = $"SP_EditCauhoi @Baitoan , @dapan1 , @dapan2 , @dapan3 , @dapan4 , @dapan  ";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                cauhoi.baitoan,
                cauhoi.dapan1,
                cauhoi.dapan2,
                cauhoi.dapan3,
                cauhoi.dapan4,
                cauhoi.dapan
            });
        }
        public void deletecauhoi(string key)
        {
            string query = $"SP_deleteCauhoi @baitoan";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                key,
            });
        }

        public void updatedachon(DTO_CauHoi cauHoi)
        {
            string query = $"updatechc @dapanchon , @cauhoiid , @testid";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                cauHoi.dapanchon,
                cauHoi.cauhoiID,
                cauHoi.testID,
            });
        }
    }
}
