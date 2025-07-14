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
    public partial class frm_LichSuDatSan : Form
    {
        public frm_LichSuDatSan()
        {
            InitializeComponent();
        }

        private void frm_LichSuDatSan_Load(object sender, EventArgs e)
        {
                cb_san.Items.Clear();
                for (int i = 1; i <= 5; i++)
                {
                    cb_san.Items.Add("Sân " + i);
                }
                cb_san.SelectedIndex = 0;
                dtp_batdau.Format = DateTimePickerFormat.Short;
                dtp_ketthuc.Format = DateTimePickerFormat.Short;
            }

        private void btn_tim_Click(object sender, EventArgs e)
        {
                string tenKH = txt_tenkh.Text.Trim();
                DateTime tuNgay = dtp_batdau.Value.Date;
                DateTime denNgay = dtp_ketthuc.Value.Date;
                string sanSo = cb_san.SelectedItem.ToString();
                DataTable dt = LichSuDatSan(tenKH, tuNgay, denNgay, sanSo);

                dtgv_lichsudatsan.DataSource = dt;
            }

        }
}
