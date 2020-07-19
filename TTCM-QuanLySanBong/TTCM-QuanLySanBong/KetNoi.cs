using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TTCM_QuanLySanBong
{
    public class KetNoi
    {
        private static KetNoi inst;
       
        private string conStr = @"Data Source=DESKTOP-PBM2SJ4\SQLEXPRESS;Initial Catalog=QuanLySanBong;Integrated Security=True";

        public static KetNoi Istance
        {
            get
            {
                if (inst == null)
                    inst = new KetNoi();
                return KetNoi.inst;
            }
            private set
            {
                KetNoi.inst = value;
            }
        }

        public DataTable ExcuteQuerry(string querry)
        {
            //DataTable data = new DataTable();
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = ConfigurationManager.ConnectionStrings["TTCM_QuanLySanBong"].ConnectionString;
            //connection.Open();
            //DataSet ds = new DataSet();
            //SqlCommand command = new SqlCommand(querry, connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.Fill(data);
            //connection.Close();
            //return data;
            DataTable data = new DataTable();
            SqlConnection connect = new SqlConnection(conStr);
            connect.Open();
            SqlCommand command = new SqlCommand(querry, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connect.Close();
            return data;
        }
    }
}
