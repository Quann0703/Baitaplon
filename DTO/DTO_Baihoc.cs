using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Baihoc
    {
        public int mabaihoc { get; set; }

        public int malop { get; set; }  

        public string tenbaihoc { get; set; }

        public DTO_Baihoc() { }
        public DTO_Baihoc(int mabaihoc, int malop, string tenbaihoc)
        {
            this.mabaihoc = mabaihoc;
            this.malop = malop;
            this.tenbaihoc = tenbaihoc;
        }

        public DTO_Baihoc(DataRow row)
        {
            this.mabaihoc = (int)row["Baihoc_ID"];
            this.malop = (int)row["lop_ID"];
            this.tenbaihoc = row["tenbaihoc"].ToString();
        }
    }
}
