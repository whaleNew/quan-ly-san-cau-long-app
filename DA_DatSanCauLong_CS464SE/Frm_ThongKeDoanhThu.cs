using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DatSanCauLong_CS464SE
{
    public partial class Frm_ThongKeDoanhThu : Form
    {
        public Frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            dtp_ngaydau.Value = DateTime.Now;
            dtp_ngaycuoi.Value = DateTime.Now;
            if (cb_san.Items.Count > 0)
                cb_san.SelectedIndex = 0;
            dtgv_thongkedoanhthu.DataSource = null;
            txt_tongdoanhthu.Clear();
        }
    }
}
