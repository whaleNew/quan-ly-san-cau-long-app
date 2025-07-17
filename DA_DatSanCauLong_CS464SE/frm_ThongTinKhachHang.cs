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
    public partial class frm_ThongTinKhachHang : Form
    {
        private LOPDUNGCHUNG lopdungchung;
        public frm_ThongTinKhachHang()
        {
            InitializeComponent();
            lopdungchung = new LOPDUNGCHUNG();

        }
        public void LoadKH()
        {
            // Load Danh Sách Khách Hàng
            //string sql = "Select * From KhachHang";
            //DataTable dt = new DataTable();
            //dtgr_DanhSachKhachHang.DataSource = lopdungchung.LoadDL(sql);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Thêm Mới Khách Hàng
            //string sql = "Insert Into KhachHang values (); // Truyền txtbox vào
            //int kq = (int)lopdungchung.ThemXoaSua(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Thêm Thành Công", "Thông Báo");
            //}
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Sửa Khách Hàng
            //string sql = $"Update KhachHang Set HoTen = ...;
            //int kq = (int)lopdungchung.ThemXoaSua(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Sửa thành công", "Thông Báo");
            //    LoadKH();
            //}
        }

        private void dtgr_DanhSachKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Xóa Khách Hàng
            //string makh = txt_MaKH.Text;
            //string sql = $"Delete From KhachHang Where MaKH = {makh}";
            //int kq = (int)lopdungchung.ThemXoaSua(sql);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Xóa Khách Hàng Thành Công", "Thông Báo");
            //    LoadKH();
            //}
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(tb == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
