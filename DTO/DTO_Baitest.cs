using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Baitest
    {
        public int testID { get; set; } 
        public int baihocID { get; set; }
        public string tenbaitest { get; set; }

        public DateTime nagytest { get; set; }

        public int gvID { get; set; }

        public DTO_Baitest()
        {

        }

        public DTO_Baitest(int testID, int baihocID, string tenbaitest, DateTime nagytest, int gvID)
        {
            this.testID = testID;
            this.baihocID = baihocID;
            this.tenbaitest = tenbaitest;
            this.nagytest = nagytest;
            this.gvID = gvID;
        }

        public DTO_Baitest(DataRow row)
        {
            this.testID = (int)row["TestID"];
            this.baihocID = (int)row["Baihoc_ID"];
            this.tenbaitest = row["TenBaiTest"].ToString();
            this.nagytest = (DateTime)row["NgayTest"];
            this.gvID = (int)row["GV_ID"];
        }
    }
}
