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
    public class BUS_HS
    {
        DAL_HS dalhs = new DAL_HS();
        public DataTable getHS()
        {
            return dalhs.getHS();
        }
        public DataTable getUsersID()
        {
            return dalhs.getusersID();
        }
        public DataTable getLopID()
        {
            return dalhs.getlopID();
        }
        public void AddHS(DTO_HS hs)
        {
            dalhs.addHS(hs);
        }
        public void updateHS(DTO_HS hs)
        {
            dalhs.editHS(hs);
        }
        public void deleteHS(int mahs)
        {
            dalhs.deleteHS(mahs);
        }
        public DataTable seachhs(string key)
        {
            return dalhs.seachhs(key);
        }
        

        public void KetXuatWord(string exportPath)
        {
            WordHelper.ExportToWord(dalhs.getHS(), "Template\\HocSinh_Template.docx", exportPath, new List<string>()
            {
                "users__ID"
            });
        }
    }
}
