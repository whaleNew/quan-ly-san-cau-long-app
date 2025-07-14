namespace DA_DatSanCauLong_CS464SE
{
    partial class frm_LichSuDatSan
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
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_batdau = new System.Windows.Forms.DateTimePicker();
            this.dtp_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_san = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.dtgv_lichsudatsan = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giờ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.san = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_lammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lichsudatsan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ ĐẶT SÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(234, 45);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(207, 26);
            this.txt_tenkh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian";
            // 
            // dtp_batdau
            // 
            this.dtp_batdau.Location = new System.Drawing.Point(191, 96);
            this.dtp_batdau.Name = "dtp_batdau";
            this.dtp_batdau.Size = new System.Drawing.Size(167, 26);
            this.dtp_batdau.TabIndex = 4;
            // 
            // dtp_ketthuc
            // 
            this.dtp_ketthuc.Location = new System.Drawing.Point(461, 96);
            this.dtp_ketthuc.Name = "dtp_ketthuc";
            this.dtp_ketthuc.Size = new System.Drawing.Size(167, 26);
            this.dtp_ketthuc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sân số";
            // 
            // cb_san
            // 
            this.cb_san.FormattingEnabled = true;
            this.cb_san.Items.AddRange(new object[] {
            "Sân 1",
            "Sân 2",
            "Sân 3",
            "Sân 4",
            "Sân 5",
            "Sân 6"});
            this.cb_san.Location = new System.Drawing.Point(191, 149);
            this.cb_san.Name = "cb_san";
            this.cb_san.Size = new System.Drawing.Size(121, 28);
            this.cb_san.TabIndex = 7;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(257, 206);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(111, 42);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // dtgv_lichsudatsan
            // 
            this.dtgv_lichsudatsan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_lichsudatsan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.kh,
            this.ngaydat,
            this.giờ1,
            this.gio2,
            this.san,
            this.status,
            this.note});
            this.dtgv_lichsudatsan.Location = new System.Drawing.Point(12, 272);
            this.dtgv_lichsudatsan.Name = "dtgv_lichsudatsan";
            this.dtgv_lichsudatsan.RowTemplate.Height = 28;
            this.dtgv_lichsudatsan.Size = new System.Drawing.Size(843, 150);
            this.dtgv_lichsudatsan.TabIndex = 9;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // kh
            // 
            this.kh.HeaderText = "Tên khách hàng";
            this.kh.Name = "kh";
            // 
            // ngaydat
            // 
            this.ngaydat.HeaderText = "Ngày đặt";
            this.ngaydat.Name = "ngaydat";
            // 
            // giờ1
            // 
            this.giờ1.HeaderText = "Giờ bắt đầu";
            this.giờ1.Name = "giờ1";
            // 
            // gio2
            // 
            this.gio2.HeaderText = "Giờ kết thúc";
            this.gio2.Name = "gio2";
            // 
            // san
            // 
            this.san.HeaderText = "Sân";
            this.san.Name = "san";
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            // 
            // note
            // 
            this.note.HeaderText = "Ghi chú";
            this.note.Name = "note";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(424, 206);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(96, 42);
            this.btn_lammoi.TabIndex = 10;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // frm_LichSuDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 675);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.dtgv_lichsudatsan);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.cb_san);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_ketthuc);
            this.Controls.Add(this.dtp_batdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_LichSuDatSan";
            this.Text = "frm_LichSuDatSan";
            this.Load += new System.EventHandler(this.frm_LichSuDatSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lichsudatsan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_batdau;
        private System.Windows.Forms.DateTimePicker dtp_ketthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_san;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.DataGridView dtgv_lichsudatsan;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn giờ1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn san;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button btn_lammoi;
    }
}