using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_tailieu
    {
        public int matailieu { get; set; }

        public int mabaihoc { get; set; }

        public string tentailieu { get; set; }

        public string file { get; set; }

        public string mota { get; set; }

        public int magv { get; set; }

        public DTO_tailieu() { }
        public DTO_tailieu(int matailieu, int mabaihoc, string tentailieu, string file, string mota, int magv)
        {
            this.matailieu = matailieu;
            this.mabaihoc = mabaihoc;
            this.tentailieu = tentailieu;
            this.file = file;
            this.mota = mota;
            this.magv = magv;
        }
        public DTO_tailieu(DataRow row)
        {
            this.matailieu = (int)row["Tailieu_ID"];
            this.mabaihoc = (int)row["baihoc_ID"];
            this.tentailieu = row["TenTailieu"].ToString();
            this.file = row["Files"].ToString();
            this.mota = row["Mota"].ToString();
            this.magv = (int)row["GV_ID"];
        }
    }
}
