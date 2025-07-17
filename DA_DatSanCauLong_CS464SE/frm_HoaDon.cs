using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_DataBase;

namespace DA_DatSanCauLong_CS464SE
{
    public partial class frm_HoaDon : Form
    {
        private LOPDUNGCHUNG lopdungchung;

        public frm_HoaDon()
        {
            InitializeComponent();
            lopdungchung = new LOPDUNGCHUNG();
        }
        public void LoadHoaDon()
        {
            // Load Danh Sách Hóa Đơn
            //string sql = "Select * From HoaDon";
            //DataTable dt = new DataTable();
            //dtgr_HoaDon.DataSource = lopdungchung.LoadDL(sql);

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Thêm Mới Hóa Đơn
            //string sql = "Insert Into HoaDon values (); // Truyền txtbox vào
            //int kq = (int)lopdungchung.ThemXoaSua(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Thêm Thành Công", "Thông Báo");
            //} 
            // LoadHoaDon();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Sửa Hóa ĐƠn
            //string sql = $"Update HoaDon Set HoTen = ...;
            //int kq = (int)lopdungchung.ThemXoaSua(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Sửa thành công", "Thông Báo");
            // LoadHoaDon();
            //}
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa Hóa Đơn
            //string mahd = txt_MaHoaDon.Text;
            //string sql = $"Delete From HoaDon Where MaHoaDon = {mahd}";
            //int kq = (int)lopdungchung.ThemXoaSua(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Xóa Thành Công", "Thông Báo");
            // LoadHoaDon();
            //}
        }
    }
}
