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
    public partial class QLNhaHang : Form
    {
        DataTable dt;
        public QLNhaHang()
        {
            InitializeComponent();
        }

        private void QLNhaHang_Load(object sender, EventArgs e)
        {
            cmbLoaiHang.DataSource = LoaiHangBLL.Instance.LoaiHang_Select();
            cmbLoaiHang.DisplayMember = "TenLoaiHang";
            cmbLoaiHang.ValueMember = "MaLoaiHang";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvCTHD.SelectedItems[0];
            foreach (ListViewItem item2 in lsvCTHD.Items)
            {
                ListViewItem item3 = new ListViewItem(item2.Text);
                //item3.SubItems.Add(item3.)
            }

        }

        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvCTHD.Items.Clear();
            dt = HangHoaBLL.Instance.HangHoa_SelectByMaLH(cmbLoaiHang.SelectedValue.ToString());
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaHang"].ToString());
                for(int i = 1; i < dt.Columns.Count;i++)
                {
                    item.SubItems.Add(row["TenHang"].ToString());
                    item.SubItems.Add(row["DVT"].ToString());
                    item.SubItems.Add(row["DonGia"].ToString());
                    item.SubItems.Add(row["SLcon"].ToString());

                }
                lsvCTHD.Items.Add(item);
            }
        }
    }
}
