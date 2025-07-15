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
    public partial class frm_QuanLySan : Form
    {
        LOPDUNGCHUNG lop = new LOPDUNGCHUNG();
        public frm_QuanLySan()
        {
            InitializeComponent();
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh sân";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                pic_Hinhanh.Image = Image.FromFile(path); // Hiển thị ảnh
                pic_Hinhanh.Tag = path; // Lưu đường dẫn vào Tag để sử dụng sau
            }
        }
        private void LoadDataToGrid()
        {
            string sql = "SELECT MaSan, TenSan, GiaSan, TrangThai, HinhAnh FROM SAN";
            DataTable dt = lop.LoadDL(sql);
            dtgr_SanCau.DataSource = dt;

        
            dtgr_SanCau.Columns[0].HeaderText = "Mã Sân";
            dtgr_SanCau.Columns[1].HeaderText = "Tên Sân";
            dtgr_SanCau.Columns[2].HeaderText = "Giá Sân";
            dtgr_SanCau.Columns[3].HeaderText = "Trạng Thái";
            dtgr_SanCau.Columns[4].HeaderText = "Hình Ảnh";

         
            dtgr_SanCau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void frm_QuanLySan_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            dtgr_SanCau.CellClick += dtgr_SanCau_CellClick;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maSan = txt_maSan.Text.Trim();
            string tenSan = txt_tenSan.Text.Trim();
            string giaSan = txt_giaSan.Text.Trim();
            string trangThai = txt_Status.Text.Trim();
            string hinhAnh = pic_Hinhanh.Tag != null ? pic_Hinhanh.Tag.ToString() : "";

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(maSan) || string.IsNullOrEmpty(tenSan) || string.IsNullOrEmpty(giaSan) || string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sân.");
                return;
            }

            if (!int.TryParse(giaSan, out int gia))
            {
                MessageBox.Show("Giá sân phải là số nguyên.");
                return;
            }

            // Câu lệnh thêm
            string sql = $"INSERT INTO SAN (MaSan, TenSan, GiaSan, TrangThai, HinhAnh) " +
                         $"VALUES ('{maSan}', N'{tenSan}', {gia}, N'{trangThai}', N'{hinhAnh}')";

            try
            {
                lop.ThemXoaSua(sql);
                MessageBox.Show("Thêm sân thành công!");
                LoadDataToGrid(); // cập nhật lại lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sân: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maSan = txt_maSan.Text.Trim();
            string tenSan = txt_tenSan.Text.Trim();
            string giaSan = txt_giaSan.Text.Trim();
            string trangThai = txt_Status.Text.Trim();
            string hinhAnh = pic_Hinhanh.Tag != null ? pic_Hinhanh.Tag.ToString() : "";

            if (string.IsNullOrEmpty(maSan))
            {
                MessageBox.Show("Vui lòng chọn sân để sửa.");
                return;
            }

            if (!int.TryParse(giaSan, out int gia))
            {
                MessageBox.Show("Giá sân phải là số nguyên.");
                return;
            }

            string sql = $"UPDATE SAN SET TenSan = N'{tenSan}', GiaSan = {gia}, " +
                         $"TrangThai = N'{trangThai}', HinhAnh = N'{hinhAnh}' WHERE MaSan = '{maSan}'";

            try
            {
                lop.ThemXoaSua(sql);
                MessageBox.Show("Cập nhật sân thành công!");
                LoadDataToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maSan = txt_maSan.Text.Trim();

            if (string.IsNullOrEmpty(maSan))
            {
                MessageBox.Show("Vui lòng chọn sân để xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sân này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            string sql = $"DELETE FROM SAN WHERE MaSan = '{maSan}'";

            try
            {
                lop.ThemXoaSua(sql);
                MessageBox.Show("Xóa sân thành công!");
                LoadDataToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void dtgr_SanCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgr_SanCau.Rows[e.RowIndex];
                txt_maSan.Text = row.Cells["MaSan"].Value?.ToString();
                txt_tenSan.Text = row.Cells["TenSan"].Value?.ToString();
                txt_giaSan.Text = row.Cells["GiaSan"].Value?.ToString();
                txt_Status.Text = row.Cells["TrangThai"].Value?.ToString();

                string path = row.Cells["HinhAnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    pic_Hinhanh.Image = Image.FromFile(path);
                    pic_Hinhanh.Tag = path;
                }
                else
                {
                    pic_Hinhanh.Image = null;
                    pic_Hinhanh.Tag = null;
                }
            }
        }

        private void btn_Fresh_Click(object sender, EventArgs e)
        {
            txt_maSan.Clear();
            txt_tenSan.Clear();
            txt_giaSan.Clear();
            txt_Status.Clear();

            // Xóa ảnh và tag (đường dẫn)
            pic_Hinhanh.Image = null;
            pic_Hinhanh.Tag = null;

            // Load lại dữ liệu lưới
            LoadDataToGrid();

           
        }
    }
}
