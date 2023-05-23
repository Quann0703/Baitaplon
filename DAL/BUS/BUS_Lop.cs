using BUS.Helper;
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
    public  class BUS_Lop
    {
        DAL_Lop dallop = new DAL_Lop();
        public int baitestwidth = 90;
        public int baitestheight = 50;
        public DataTable getLop()
        {
            return dallop.getLop();
        }
        public DataTable getGVID()
        {
            return dallop.getGVID();
        }
        public void AddHS(DTO_Lop lop)
        {
            dallop.addLop(lop);
        }
        public void updateHS(DTO_Lop lop)
        {
            dallop.editLop(lop);
        }
        public void deleteHS(int mahs)
        {
            dallop.deletelop(mahs);
        }
        public DataTable seachhs(string key)
        {
            return dallop.seachLop(key);
        }
        public void KetXuatWord(string exportPath)
        {
            WordHelper.ExportToWord(dallop.getLop(), "Template\\Classic_Template.docx", exportPath, new List<string>()
            {
                "users__ID"
            });
        }

        public List<DTO_Lop> loadlistlop()
        {
            List<DTO_Lop> listlop = new List<DTO_Lop>();
            DataTable data = dallop.getLop();
            foreach(DataRow item in data.Rows)
            {
                DTO_Lop lop = new DTO_Lop(item);
                listlop.Add(lop);
            }
            return listlop;
        }
    }
}
