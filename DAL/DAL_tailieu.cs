using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_tailieu
    {
        public DataTable gettailieu()
        {
            string query = $"SP_hienthiTailieu";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }
        public DataTable getmabaihoc()
        {
            string query = $"SP_hienthimabaihoc";
            return DAL__dataprovider.Instance.ExecuteQuery(query);  
        }

        public DataTable getmagiaovien()
        {
            string query = $"SP_getGVID";
            return DAL__dataprovider.Instance.ExecuteQuery(query);
        }

        public void addTailieu(DTO_tailieu tl)
        {
            string query = $"SP_Addtailieu @taikieuID , @BaihocID , @tentailieu , @file , @mota , @gvID";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                tl.matailieu,
                tl.mabaihoc,
                tl.tentailieu,
                tl.file,
                tl.mota,
                tl.magv
            });
        }

        public void editTailieu(DTO_tailieu tl)
        {
            string query = $"SP_Edittailieu @taikieuID , @BaihocID , @tentailieu , @file , @mota , @gvID";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                tl.matailieu,
                tl.mabaihoc,
                tl.tentailieu,
                tl.file,
                tl.mota,
                tl.magv
            });
        }

        public void deletetailieu(int matailieu)
        {
            string query = $"SP_deletetailieu @taikieuID";
            DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                matailieu
            });
        }
        public DataTable laytailieu(int mabh)
        {
            string query = $"SP_laytailieu @baihocid";
            return DAL__dataprovider.Instance.ExecuteQuery(query, new object[]
            {
                mabh
            });
        }
    }
}
