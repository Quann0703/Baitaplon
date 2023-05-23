using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Baihoc
    {
        DAL_Baihoc dalbaihoc = new DAL_Baihoc();
        public int baitestwidth = 110;
        public int baitestheight = 60;
        public DataTable getmalop()
        {
            return dalbaihoc.getmalop();
        }

        public DataTable getbaihoc()
        {
            return dalbaihoc.getBaihoc();
        }

        public void addbaihoc(DTO_Baihoc baihoc)
        {
            dalbaihoc.Addbaihoc(baihoc);
        }
        public void editbaihoc(DTO_Baihoc baihoc)
        {
            dalbaihoc.Editbaihoc(baihoc);
        }

        public void deletebaihoc(int mabaihoc)
        {
            dalbaihoc.deletebaihoc(mabaihoc);
        }

        public List<DTO_Baihoc> loadlistbaihoc(int malop)
        {
            List<DTO_Baihoc> dsbaihoc = new List<DTO_Baihoc>();
            DataTable data = dalbaihoc.getlop_malop(malop);
            foreach(DataRow item in data.Rows)
            {
                DTO_Baihoc bh = new DTO_Baihoc(item);
                dsbaihoc.Add(bh);
            }
            return dsbaihoc;
        }
    }
}
