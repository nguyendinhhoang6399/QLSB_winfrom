using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM_QuanLySanBong
{
    public partial class frmBieuDo : Form
    {
        private string query;
        public frmBieuDo(string QUERY)
        {
            this.query = QUERY;
            InitializeComponent();
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            foreach(DataRow row in data.Rows)
            {
                chart1.Series["DoanhThu"].Points.AddXY(row["NgayXuat"], (Decimal.Parse(row["TongTien"].ToString())));
            }
        }

        public string Query { get => query; set => query = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
