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
    public partial class Frm_ThongKeDoanhThu : Form
    {
        LOPDUNGCHUNG lop = new LOPDUNGCHUNG();
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
        bool isFormLoaded = false; // khai báo trong class

        private void Frm_ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LoadSanToComboBox(); // Gán dữ liệu vào combobox trước
            dtp_ngaydau.Value = DateTime.Now.AddDays(-7);
            dtp_ngaycuoi.Value = DateTime.Now;
            isFormLoaded = true; // Đánh dấu form đã được tải xong
            LoadDataToGrid(); // Nạp dữ liệu vào DataGridView khi form được tải
        }
        private void LoadSanToComboBox()
        {
            string sql = "SELECT MaSan, TenSan FROM SAN";
            DataTable dt = lop.LoadDL(sql);
            cb_san.DataSource = dt;
            cb_san.DisplayMember = "TenSan";
            cb_san.ValueMember = "MaSan";
            cb_san.SelectedIndex = -1; // Không chọn gì ban đầu
        }

        private void LoadDataToGrid()
        {
            string tuNgay = dtp_ngaydau.Value.ToString("yyyy-MM-dd");
            string denNgay = dtp_ngaycuoi.Value.ToString("yyyy-MM-dd");
            string maSan = cb_san.SelectedValue?.ToString(); // nếu cb_san có ValueMember = MaSan

            string sql = $@"
        SELECT 
            s.TenSan AS [Sân số],
            ds.NgayDat AS [Ngày đặt],
            ds.GioBatDau AS [Giờ bắt đầu],
            ds.GioKetThuc AS [Giờ kết thúc],
            DATEDIFF(HOUR, ds.GioBatDau, ds.GioKetThuc) * s.GiaSan AS [Doanh thu]
        FROM DATSAN ds
        JOIN SAN s ON ds.MaSan = s.MaSan
        WHERE ds.NgayDat BETWEEN '{tuNgay}' AND '{denNgay}'";

            // Nếu có chọn sân cụ thể thì lọc theo sân
            if (!string.IsNullOrEmpty(maSan))
            {
                sql += $" AND ds.MaSan = '{maSan}'";
            }

            DataTable dt = lop.LoadDL(sql); // lop là lớp dùng chung

            dtgv_thongkedoanhthu.DataSource = dt;

            dtgv_thongkedoanhthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tính tổng doanh thu
            decimal tong = 0;
            foreach (DataGridViewRow row in dtgv_thongkedoanhthu.Rows)
            {
                if (row.Cells["Doanh thu"].Value != null && decimal.TryParse(row.Cells["Doanh thu"].Value.ToString(), out decimal doanhthu))
                {
                    tong += doanhthu;
                }
            }

            txt_tongdoanhthu.Text = tong.ToString("N0") + " VNĐ";
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
        private void cb_san_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_san.SelectedIndex != -1)
            {
                LoadDataToGrid();
            }
        }

    }
}
