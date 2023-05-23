using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        public int maLop { get; set; }
        public string tenlop { get; set; }
        public int magvcn { get; set; }
        public string namhoc { get; set; }

        public DTO_Lop() { }

        public DTO_Lop(int maLop, string tenlop, int magvcn, string namhoc)
        {
            this.maLop = maLop;
            this.tenlop = tenlop;
            this.magvcn = magvcn;
            this.namhoc = namhoc;
        }

        public DTO_Lop(DataRow row)
        {
            this.maLop = (int)row["Lop_ID"];
            this.tenlop = row["TenLop"].ToString();
            this.magvcn = (int)row["MaGVCN"];
            this.namhoc = row["Namhoc"].ToString();
        }
    }
}
