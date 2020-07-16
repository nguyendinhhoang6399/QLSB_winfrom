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
    public partial class frmBieuDo2 : Form
    {
        private string query;
        public frmBieuDo2(string QUERY)
        {
            this.query = QUERY;
            InitializeComponent();
            DataTable data = KetNoi.Istance.ExcuteQuerry(query);
            foreach (DataRow row in data.Rows)
            {
                chart1.Series["Vốn"].Points.AddXY(row["NgayNhap"], (Decimal.Parse(row["ThanhTien"].ToString())));
            }
        }
        public string Query { get => query; set => query = value; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
