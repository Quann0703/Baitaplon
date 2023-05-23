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
    public class BUS_CauHoi
    {
        DAL_CauHoi dalch = new DAL_CauHoi();
        public int baitestwidth = 100;
        public int baitestheight = 50;
        public DataTable getTestID()
        {
            return dalch.getTestID();
        }
        public DataTable getcauhoi(string key)
        {
            return dalch.getcauhoi(key);
        }
        public DataTable hienthicauhoi()
        {
            return dalch.hienthicauhoi();
        }

        public void addCauhoi(DTO_CauHoi cauhoi)
        {
            dalch.addCauhoi(cauhoi);
        }
        public void editCauhoi(DTO_CauHoi cauhoi)
        {
            dalch.editcauhoi(cauhoi);
        }
        public void Deletecauhoi(string key)
        {
            dalch.deletecauhoi(key);
        }
        public List<DTO_CauHoi> loadcauhoilist(int id)
        {
            List<DTO_CauHoi> dtcauhoi = new List<DTO_CauHoi> ();
            DataTable data = dalch.gettestid(id);
            foreach(DataRow item in data.Rows)
            {
                DTO_CauHoi quetion = new DTO_CauHoi(item);
                dtcauhoi.Add(quetion);
            }
            return dtcauhoi;
        }
        public List<DTO_CauHoi> laycauhoi(int id , int cauhoiid)
        {
            List<DTO_CauHoi> debai = new List<DTO_CauHoi>();
            DataTable data = dalch.laycauhoi(id, cauhoiid);
            foreach(DataRow item in data.Rows)
            {
                DTO_CauHoi debaicauhoi = new DTO_CauHoi(item);
                debai.Add(debaicauhoi);
            }
            return debai;
        }
        public void updatedac(DTO_CauHoi cauHoi)
        {
            dalch.updatedachon(cauHoi);
        }
    }
}
