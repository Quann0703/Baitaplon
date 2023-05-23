using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HS
    {
        public int HS_ID { get; set; }

        public int users__ID { get; set; }

        public string HoTen { get; set; }

        public string NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public string Diachi { get; set; }
        public int Lop_ID { get; set; }

        public string SDT { get; set; }

        public string Email { get; set; }

        public DTO_HS() { }
        
        public DTO_HS(int HS_ID , int users__ID , string HoTen ,string NgaySinh ,string GioiTinh , string Diachi , int Lop_ID , string SDT , string Email)
        {
            this.HS_ID = HS_ID;
            this.users__ID = users__ID;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.Diachi = Diachi;
            this.Lop_ID = Lop_ID;
            this.SDT = SDT;
            this.Email = Email;
        }
        public DTO_HS(int HS_ID , string HoTen , string NgaySinh , string Diachi , int Lop_ID , string SDT , string Email)
        {
            this.HS_ID=HS_ID;
            this .HoTen = HoTen;
            this.NgaySinh=NgaySinh;
            this.Diachi=Diachi;
            this.Lop_ID=Lop_ID;
            this.SDT=SDT;
            this.Email = Email;
        }
    }
}
