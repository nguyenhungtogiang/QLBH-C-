using BLL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = CTHD_BLL.Instance.CTHD_HDBH("HD9");
            HoaDonBanHang rp = new HoaDonBanHang();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
