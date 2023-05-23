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
    public class BUS_KiemTra
    {
        DAL_KiemTra dalkt = new DAL_KiemTra();
        public  int baitestwidth = 100;
        public  int baitestheight = 50;
        public List<DTO_Baitest> Loadbaitestlist()
        {
            List<DTO_Baitest> baitestslist = new List<DTO_Baitest>();
            DataTable data = dalkt.getbaitest();
            foreach (DataRow item in data.Rows)
            {
                DTO_Baitest baitest = new DTO_Baitest(item);
                baitestslist.Add(baitest);
            }
            return baitestslist;
        }
        public List<DTO_Baitest> getTest(int id)
        {
            List<DTO_Baitest> listTest = new List<DTO_Baitest>();
            DataTable data = dalkt.gettestid(id);
            foreach(DataRow item in data.Rows)
            {
                DTO_Baitest TestID = new DTO_Baitest(item);
                listTest.Add(TestID);
            }
            return listTest;
        }
    }
}
