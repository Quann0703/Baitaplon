using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CauHoi
    {
        public int ID { get; set; }
        public int cauhoiID { get; set; }
        public int testID { get; set; }

        public string baitoan { get; set; }

        public string dapan1 { get; set; }

        public string dapan2 { get; set; }

        public string dapan3 { get; set; }

        public string dapan4 { get; set; }

        public string dapan { get; set; }

        public string dapanchon { get; set; }

        public DTO_CauHoi()
        {

        }

        public DTO_CauHoi(int cauhoiID, int testID, string baitoan, string dapan1, string dapan2, string dapan3, string dapan4, string dapan)
        {
            this.cauhoiID = cauhoiID;
            this.testID = testID;
            this.baitoan = baitoan;
            this.dapan1 = dapan1;
            this.dapan2 = dapan2;
            this.dapan3 = dapan3;
            this.dapan4 = dapan4;
            this.dapan = dapan;
        }

        public DTO_CauHoi(string baitoan, string dapan1, string dapan2, string dapan3, string dapan4, string dapan)
        {
            this.baitoan = baitoan;
            this.dapan1 = dapan1;
            this.dapan2 = dapan2;
            this.dapan3 = dapan3;
            this.dapan4 = dapan4;
            this.dapan = dapan;
        }
        public DTO_CauHoi( int cauhoiID, int testID, string baitoan, string dapanchon)
        {
            this.cauhoiID = cauhoiID;
            this.testID = testID;
            this.baitoan = baitoan;
            this.dapan = dapan;
            this.dapanchon = dapanchon;
        }

        public DTO_CauHoi(DataRow row)
        {
            this.cauhoiID = (int)row["cauhoi_ID"];
            this.testID = (int)row["TestID"];
            this.baitoan = row["Baitoan"].ToString();
            this.dapan1 = row["dapan1"].ToString();
            this.dapan2 = row["dapan2"].ToString();
            this.dapan3 = row["dapan3"].ToString();
            this.dapan4 = row["dapan4"].ToString();
            this.dapan = row["dapan"].ToString();
            this.dapanchon = row["dapanchon"].ToString();
        }
    }
}
