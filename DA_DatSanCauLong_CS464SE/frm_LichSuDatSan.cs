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
   
    public partial class frm_LichSuDatSan : Form
    {
        LOPDUNGCHUNG lop = new LOPDUNGCHUNG();
        public frm_LichSuDatSan()
        {
            InitializeComponent();
        }

        private void frm_LichSuDatSan_Load(object sender, EventArgs e)
        {
              
            LoadDataToGrid(); // Nạp dữ liệu vào DataGridView khi form được tải
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string tenKH = txt_search.Text.Trim();

            string sql = $"SELECT MaDat AS [STT], TenKH AS [Tên khách hàng], NgayDat AS [Ngày đặt], GioBatDau AS [Giờ bắt đầu], GioKetThuc AS [Giờ kết thúc], MaSan AS [Sân] " +
                         $"FROM DATSAN WHERE TenKH LIKE N'%{tenKH}%'";

            DataTable dt = lop.LoadDL(sql);
            dtgv_lichsudatsan.DataSource = dt;

            dtgv_lichsudatsan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgv_lichsudatsan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataToGrid()
        {
            string sql = "SELECT MaDat AS [STT], TenKH AS [Tên khách hàng], NgayDat AS [Ngày đặt], " +
                         "GioBatDau AS [Giờ bắt đầu], GioKetThuc AS [Giờ kết thúc], MaSan AS [Sân] " +
                         "FROM DATSAN";

            DataTable dt = lop.LoadDL(sql); // lớp dùng chung của bạn

            dtgv_lichsudatsan.DataSource = dt;
            dtgv_lichsudatsan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgv_lichsudatsan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_lichsudatsan.Rows[e.RowIndex];

                // Lấy dữ liệu từ từng cột và hiển thị lên các control
                txt_tenkh.Text = row.Cells["Tên khách hàng"].Value?.ToString();
                txt_ngaydat.Text = Convert.ToDateTime(row.Cells["Ngày đặt"].Value).ToString("dd/MM/yyyy");
                txt_giobatdau.Text = row.Cells["Giờ bắt đầu"].Value?.ToString();
                txt_gioketthuc.Text = row.Cells["Giờ kết thúc"].Value?.ToString();

                // ComboBox chọn sân (giả sử có dạng "Sân 1", "Sân 2",...)
                string maSan = row.Cells["Sân"].Value?.ToString();
                txt_San.Text = "Sân " + maSan;
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            LoadDataToGrid();
        }
    }
}
