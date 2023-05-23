using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DAL__dataprovider
    {
        private static DAL__dataprovider instance;
        public static DAL__dataprovider Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DAL__dataprovider();
                }
                return instance;
            }
            private set => instance = value;
        }


        private DAL__dataprovider() { }

        static string connectionStr = @"Data Source=QUANVT\SQL;Initial Catalog=QLHTTH;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();

            using(SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if(parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string param in listPara)
                    {
                        if (param.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(param, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                da.Dispose();
            }
            return dt; 
        }
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object result = null;

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string param in listPara)
                    {
                        if (param.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(param, parameters[i]);
                            i++;
                        }
                    }
                }

                result = cmd.ExecuteScalar();
                conn.Close();
            }

            return result;
        }
    }
}
