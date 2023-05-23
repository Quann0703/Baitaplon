using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_tailieu
    {
        DAL_tailieu daltl = new DAL_tailieu();
        public int baitestwidth = 500;
        public int baitestheight = 100;
        public DataTable gettailieu()
        {
            return daltl.gettailieu();
        }
        public DataTable getmabaihoc()
        {
            return daltl.getmabaihoc();
        }
        public DataTable getmagv()
        {
            return daltl.getmagiaovien();
        }
        public void addtailieu(DTO_tailieu tl)
        {
            daltl.addTailieu(tl);
        }

        public void edittailieu(DTO_tailieu tl)
        {
            daltl.editTailieu(tl);
        }

        public void addtailieu(int matl)
        {
            daltl.deletetailieu(matl);
        }
        public void deletetailieu(int key)
        {
            daltl.deletetailieu(key);
        }

        public List<DTO_tailieu> loadtailieu(int mabh)
        {
            List<DTO_tailieu> dstailieu = new List<DTO_tailieu>();
            DataTable data = daltl.laytailieu(mabh);
            foreach (DataRow item in data.Rows)
            {
                DTO_tailieu tailieu = new DTO_tailieu(item);
                dstailieu.Add(tailieu);
            }
            return dstailieu;
        }
    }
}
