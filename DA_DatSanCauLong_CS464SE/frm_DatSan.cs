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
    public partial class frm_DatSan : Form
    {
        LOPDUNGCHUNG lop = new LOPDUNGCHUNG();
        public frm_DatSan()
        {
            InitializeComponent();
        }
        
        private void LoadDataToGrid()
        {
            string sql = "SELECT MaDat, MaSan, TenKH, SDT, NgayDat, GioBatDau, GioKetThuc FROM DATSAN";
            DataTable dt = lop.LoadDL(sql);
            dtgr_DatSan.DataSource = dt;

            // Đặt lại tiêu đề cột
            dtgr_DatSan.Columns[0].HeaderText = "Mã Đặt";
            dtgr_DatSan.Columns[1].HeaderText = "Mã Sân";
            dtgr_DatSan.Columns[2].HeaderText = "Tên Khách Hàng";
            dtgr_DatSan.Columns[3].HeaderText = "Số Điện Thoại";
            dtgr_DatSan.Columns[4].HeaderText = "Ngày Đặt";
            dtgr_DatSan.Columns[5].HeaderText = "Giờ Bắt Đầu";
            dtgr_DatSan.Columns[6].HeaderText = "Giờ Kết Thúc";
        }
        private void LoadGioVaoComboBox()
        {
            cb_Giobatdau.Items.Clear();
            cb_Gioketthuc.Items.Clear();

            // Giờ từ 06:00 đến 22:00 (mỗi giờ)
            for (int i = 6; i <= 22; i++)
            {
                string gio = i.ToString("D2") + ":00:00"; // format "07:00:00"
                cb_Giobatdau.Items.Add(gio);
                cb_Gioketthuc.Items.Add(gio);
            }

            // Tùy chọn: chọn sẵn giá trị đầu
            cb_Giobatdau.SelectedIndex = 0;
            cb_Gioketthuc.SelectedIndex = 1;
        }
        private void LoadDanhSachSan()
        {
            string sql = "SELECT MaSan, TenSan FROM SAN WHERE TrangThai = N'Hoạt Động'";
            DataTable dt = lop.LoadDL(sql);

            cb_ChonSan.DataSource = dt;
            cb_ChonSan.DisplayMember = "TenSan";  // Hiển thị tên sân
            cb_ChonSan.ValueMember = "MaSan";     // Giá trị dùng khi insert
        }
        private void frm_DatSan_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            LoadGioVaoComboBox();
            LoadDanhSachSan();
            dtgr_DatSan.CellClick += dtgr_DatSan_CellClick;
        }

        private void btn_DatSan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string maSan = cb_ChonSan.SelectedValue?.ToString(); // nếu bạn bind dữ liệu từ DB
            string tenKH = txt_Tenkh.Text.Trim();
            string sdt = txt_Sdt.Text.Trim();
            string ngayDat = dtpk_DatSan.Value.ToString("yyyy-MM-dd");
            string gioBatDau = cb_Giobatdau.SelectedItem.ToString();
            string gioKetThuc = cb_Gioketthuc.SelectedItem.ToString();

            // Kiểm tra cơ bản
            if (string.IsNullOrEmpty(maSan) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra giờ hợp lệ
            TimeSpan batDau = TimeSpan.Parse(gioBatDau);
            TimeSpan ketThuc = TimeSpan.Parse(gioKetThuc);
            if (batDau >= ketThuc)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc.");
                return;
            }

            // Tạo câu lệnh SQL thêm
            string sql = $"INSERT INTO DATSAN (MaSan, TenKH, SDT, NgayDat, GioBatDau, GioKetThuc) " +
                         $"VALUES ('{maSan}', N'{tenKH}', '{sdt}', '{ngayDat}', '{gioBatDau}', '{gioKetThuc}')";

            try
            {
                lop.ThemXoaSua(sql);
                MessageBox.Show("Đặt sân thành công!");
                LoadDataToGrid(); // load lại
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt sân: " + ex.Message);
            }
        }

        private void btn_TinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan gioBatDau = TimeSpan.Parse(cb_Giobatdau.Text);
                TimeSpan gioKetThuc = TimeSpan.Parse(cb_Gioketthuc.Text);

                double soGio = (gioKetThuc - gioBatDau).TotalHours;

                if (soGio <= 0)
                {
                    MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu!");
                    return;
                }

                string maSan = cb_ChonSan.SelectedValue.ToString();
                string sql = $"SELECT GiaSan FROM SAN WHERE MaSan = '{maSan}'";
                object kq = lop.LayGT(sql);
                int giaSan = Convert.ToInt32(kq);

                double tongTien = soGio * giaSan;
                txt_Tongtien.Text = tongTien.ToString("N0") + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tiền: " + ex.Message);
            }
        }

        private void btn_SuaLich_Click(object sender, EventArgs e)
        {
            string maDat = txt_Madat.Text;
            if (string.IsNullOrEmpty(maDat))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trong bảng.");
                return;
            }

            string maSan = cb_ChonSan.SelectedValue?.ToString();
            string tenKH = txt_Tenkh.Text.Trim();
            string sdt = txt_Sdt.Text.Trim();
            string ngayDat = dtpk_DatSan.Value.ToString("yyyy-MM-dd");
            string gioBatDau = cb_Giobatdau.Text;
            string gioKetThuc = cb_Gioketthuc.Text;

            TimeSpan batDau = TimeSpan.Parse(gioBatDau);
            TimeSpan ketThuc = TimeSpan.Parse(gioKetThuc);

            if (batDau >= ketThuc)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc.");
                return;
            }

            string sql = $"UPDATE DATSAN SET " +
                         $"MaSan = '{maSan}', TenKH = N'{tenKH}', SDT = '{sdt}', " +
                         $"NgayDat = '{ngayDat}', GioBatDau = '{gioBatDau}', GioKetThuc = '{gioKetThuc}' " +
                         $"WHERE MaDat = {maDat}";

            try
            {
                lop.ThemXoaSua(sql);
                MessageBox.Show("Cập nhật thành công!");
                LoadDataToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void dtgr_DatSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgr_DatSan.Rows[e.RowIndex];
                txt_Madat.Text = row.Cells["MaDat"].Value.ToString(); // Thêm 1 textbox ẩn để lưu MaDat
                cb_ChonSan.SelectedValue = row.Cells["MaSan"].Value.ToString();
                txt_Tenkh.Text = row.Cells["TenKH"].Value.ToString();
                txt_Sdt.Text = row.Cells["SDT"].Value.ToString();
                dtpk_DatSan.Value = Convert.ToDateTime(row.Cells["NgayDat"].Value);
                cb_Giobatdau.Text = row.Cells["GioBatDau"].Value.ToString();
                cb_Gioketthuc.Text = row.Cells["GioKetThuc"].Value.ToString();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_Tenkh.Clear();
            txt_Sdt.Clear();
            txt_Tongtien.Clear();

            // Đặt lại giá trị mặc định cho combobox giờ
            if (cb_Giobatdau.Items.Count > 0)
                cb_Giobatdau.SelectedIndex = 0;

            if (cb_Gioketthuc.Items.Count > 1)
                cb_Gioketthuc.SelectedIndex = 1;

            // Đặt lại combobox chọn sân
            if (cb_ChonSan.Items.Count > 0)
                cb_ChonSan.SelectedIndex = 0;

            // Ngày đặt: hôm nay
            dtpk_DatSan.Value = DateTime.Now;

            // Nếu có textbox mã đặt (dùng khi sửa), thì cũng clear
            if (txt_Madat != null)
                txt_Madat.Clear();
        }
    }
}
