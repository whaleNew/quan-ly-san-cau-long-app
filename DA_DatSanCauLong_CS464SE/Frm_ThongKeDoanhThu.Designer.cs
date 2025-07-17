namespace DA_DatSanCauLong_CS464SE
{
    partial class Frm_ThongKeDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaydau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ngaycuoi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_san = new System.Windows.Forms.ComboBox();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtgv_thongkedoanhthu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tongdoanhthu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkedoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // dtp_ngaydau
            // 
            this.dtp_ngaydau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaydau.Location = new System.Drawing.Point(187, 72);
            this.dtp_ngaydau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaydau.Name = "dtp_ngaydau";
            this.dtp_ngaydau.Size = new System.Drawing.Size(209, 30);
            this.dtp_ngaydau.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày";
            // 
            // dtp_ngaycuoi
            // 
            this.dtp_ngaycuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaycuoi.Location = new System.Drawing.Point(187, 121);
            this.dtp_ngaycuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngaycuoi.Name = "dtp_ngaycuoi";
            this.dtp_ngaycuoi.Size = new System.Drawing.Size(209, 30);
            this.dtp_ngaycuoi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sân";
            // 
            // cb_san
            // 
            this.cb_san.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_san.FormattingEnabled = true;
            this.cb_san.Location = new System.Drawing.Point(187, 178);
            this.cb_san.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_san.Name = "cb_san";
            this.cb_san.Size = new System.Drawing.Size(108, 31);
            this.cb_san.TabIndex = 6;
            // 
            // btn_thongke
            // 
            this.btn_thongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.Location = new System.Drawing.Point(81, 246);
            this.btn_thongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(115, 41);
            this.btn_thongke.TabIndex = 7;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(301, 242);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(114, 44);
            this.btn_lammoi.TabIndex = 8;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(526, 242);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(110, 44);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtgv_thongkedoanhthu
            // 
            this.dtgv_thongkedoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongkedoanhthu.Location = new System.Drawing.Point(11, 311);
            this.dtgv_thongkedoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_thongkedoanhthu.Name = "dtgv_thongkedoanhthu";
            this.dtgv_thongkedoanhthu.RowHeadersWidth = 51;
            this.dtgv_thongkedoanhthu.RowTemplate.Height = 28;
            this.dtgv_thongkedoanhthu.Size = new System.Drawing.Size(743, 120);
            this.dtgv_thongkedoanhthu.TabIndex = 10;
            this.dtgv_thongkedoanhthu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // txt_tongdoanhthu
            // 
            this.txt_tongdoanhthu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongdoanhthu.Location = new System.Drawing.Point(260, 464);
            this.txt_tongdoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongdoanhthu.Name = "txt_tongdoanhthu";
            this.txt_tongdoanhthu.Size = new System.Drawing.Size(313, 34);
            this.txt_tongdoanhthu.TabIndex = 12;
            // 
            // Frm_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.txt_tongdoanhthu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgv_thongkedoanhthu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.cb_san);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_ngaycuoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_ngaydau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ThongKeDoanhThu";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.Frm_ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkedoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaydau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ngaycuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_san;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dtgv_thongkedoanhthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tongdoanhthu;
    }
}