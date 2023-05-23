using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GV
    {
       public int GVID { get; set; }
        public int users__ID { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string TrinhDo { get; set; }
        public string Email { get; set; }

        public DTO_GV() { }

        public DTO_GV(int gVID, int users__ID, string hoTen, string ngaySinh, string gioiTinh, string diachi, string sDT, string trinhDo, string email)
        {
            GVID = gVID;
            this.users__ID = users__ID;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Diachi = diachi;
            SDT = sDT;
            TrinhDo = trinhDo;
            Email = email;
        }

        public DTO_GV(int gVID , string hoTen , string ngaySinh , string diachi , string SDT , string trinhDo , string Email)
        {
            this.GVID = gVID;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.Diachi = diachi;
            this.SDT = SDT;
            this.TrinhDo = trinhDo;
            this.Email = Email;
        }
    }
}
