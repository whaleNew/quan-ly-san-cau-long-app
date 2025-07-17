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
    public partial class Frm_TaiKhoan : Form
    {
        LOPDUNGCHUNG lop = new LOPDUNGCHUNG();
        public Frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string hoTen = txt_hoten.Text.Trim();
            string email = txt_email.Text.Trim();
            string sdt = txt_sdt.Text.Trim();

            string sql = $"UPDATE TAIKHOAN SET HoTen = N'{hoTen}', SoDienThoai = '{sdt}' WHERE Email = '{email}'";

            int kq = lop.ThemXoaSua(sql); // Hàm ThucThi bạn nên có trong LOPDUNGCHUNG: ExecuteNonQuery

            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            this.dtgr_TaiKhoan.CellClick += new DataGridViewCellEventHandler(this.dtgr_TaiKhoan_CellClick);

        }
        private void LoadDataToGrid()
        {
            string sql = "SELECT HoTen, Email, SoDienThoai FROM TAIKHOAN";
            DataTable dt = lop.LoadDL(sql); // gọi lớp dùng chung đã có
            dtgr_TaiKhoan.DataSource = dt;

            // Đặt tiêu đề cột
            dtgr_TaiKhoan.Columns[0].HeaderText = "Họ tên";
            dtgr_TaiKhoan.Columns[1].HeaderText = "Email";
            dtgr_TaiKhoan.Columns[2].HeaderText = "Số điện thoại";

            // Tự động giãn cột
            dtgr_TaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgr_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txt_hoten.Text = dtgr_TaiKhoan.Rows[index].Cells["HoTen"].Value.ToString();
                txt_email.Text = dtgr_TaiKhoan.Rows[index].Cells["Email"].Value.ToString();
                txt_sdt.Text = dtgr_TaiKhoan.Rows[index].Cells["SoDienThoai"].Value.ToString();
            }
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            string mkCu = txt_mkcu.Text.Trim();
            string mkMoi = txt_mkmoi.Text.Trim();
            string xacNhan = txt_nhaplai.Text.Trim();
            string email = txt_email.Text.Trim(); // hoặc txt_tendangnhap.Text nếu dùng TenDangNhap

            // 1. Kiểm tra mật khẩu mới và xác nhận
            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu mới không khớp!");
                return;
            }

            // 2. Kiểm tra mật khẩu cũ có đúng không
            string sqlCheck = $"SELECT COUNT(*) FROM TAIKHOAN WHERE Email = '{email}' AND MatKhau = '{mkCu}'";
            DataTable dt = lop.LoadDL(sqlCheck);

            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            // 3. Đúng thì cập nhật
            string sqlUpdate = $"UPDATE TAIKHOAN SET MatKhau = '{mkMoi}' WHERE Email = '{email}'";
            int kq = lop.ThemXoaSua(sqlUpdate);

            if (kq > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                // Xoá các ô mật khẩu sau khi đổi thành công
                txt_mkcu.Clear();
                txt_mkmoi.Clear();
                txt_nhaplai.Clear();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
            }
        }
    }
}
