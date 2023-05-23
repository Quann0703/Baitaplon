using BUS.Helper;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GV
    {
        DAL_GV dalgv = new DAL_GV();
        /*public List<DTO_GV> getALL(DataTable tbGV)
        {
            List<DTO_GV> list = new List<DTO_GV>();
            foreach(DataRow row in tbGV.Rows)
            {
                DTO_GV gv = new DTO_GV();
                gv.GVID = (int)row["GV_ID"];
                
                gv.HoTen = row["HoTen"].ToString();
                gv.NgaySinh = row["NgaySinh"].ToString() ;
                gv.GioiTinh = row["GioiTinh"].ToString();
                gv.Diachi = row["Diachi"].ToString();
                gv.SDT = row["SDT"].ToString();
                gv.TrinhDo = row["Trinhdo"].ToString();
                gv.Email = row["Email"].ToString();
                list.Add(gv);
            }
            return list;
        }

        public List<DTO_GV> SeachLinq(DTO_GV gv)
        {
            var gvList = dalgv.getGV();
            if (gvList != null)
            {
                return getALL(gvList).Where
                (
                    x => x.GVID.Equals(gv.GVID) ||
                    x.HoTen.Contains(gv.HoTen) ||
                    (x.NgaySinh != null && x.NgaySinh.Contains(gv.NgaySinh)) ||
                    x.GioiTinh.Contains(gv.GioiTinh) ||
                    x.Diachi.Contains(gv.Diachi) ||
                    x.SDT.Contains(gv.SDT) ||
                    x.TrinhDo.Contains(gv.TrinhDo) ||
                    x.Email.Contains(gv.Email)
                ).ToList();
            }
            else
            {
                return new List<DTO_GV>();
            }
        }*/
        public DataTable getGV()
        {
            return dalgv.getGV();
        }
      
       public DataTable getusersID()
        {
            return dalgv.getusersID();
        }
        
        public void AddGV(DTO_GV giaovien)
        {
            dalgv.addGV(giaovien);
        }
        
        public void updateGV(DTO_GV gv)
        {
            dalgv.editGV(gv);
        }
        public void deleteGV(int magv)
        {
            dalgv.deleteGV(magv);
        }
        public DataTable seachgv(string key)
        {
            return dalgv.seachgv(key);
        }

       

        public void KetXuatWord(string exportPath)
        {
            WordHelper.ExportToWord(dalgv.getGV(), "Template\\KhachHang_Template.docx", exportPath, new List<string>()
            {
                "users__ID"
            });
        }
    }
}
