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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.dtgv_lichsudatsan = new System.Windows.Forms.DataGridView();
            this.txt_giobatdau = new System.Windows.Forms.TextBox();
            this.txt_gioketthuc = new System.Windows.Forms.TextBox();
            this.txt_ngaydat = new System.Windows.Forms.TextBox();
            this.txt_San = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lichsudatsan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ ĐẶT SÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(170, 36);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(184, 22);
            this.txt_tenkh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sân số";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(645, 204);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(80, 22);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(344, 160);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(85, 34);
            this.btn_lammoi.TabIndex = 10;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // dtgv_lichsudatsan
            // 
            this.dtgv_lichsudatsan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_lichsudatsan.Location = new System.Drawing.Point(57, 242);
            this.dtgv_lichsudatsan.Name = "dtgv_lichsudatsan";
            this.dtgv_lichsudatsan.RowHeadersWidth = 51;
            this.dtgv_lichsudatsan.RowTemplate.Height = 24;
            this.dtgv_lichsudatsan.Size = new System.Drawing.Size(668, 150);
            this.dtgv_lichsudatsan.TabIndex = 11;
            this.dtgv_lichsudatsan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_lichsudatsan_CellClick);
            // 
            // txt_giobatdau
            // 
            this.txt_giobatdau.Location = new System.Drawing.Point(170, 75);
            this.txt_giobatdau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_giobatdau.Name = "txt_giobatdau";
            this.txt_giobatdau.Size = new System.Drawing.Size(184, 22);
            this.txt_giobatdau.TabIndex = 12;
            // 
            // txt_gioketthuc
            // 
            this.txt_gioketthuc.Location = new System.Drawing.Point(433, 78);
            this.txt_gioketthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gioketthuc.Name = "txt_gioketthuc";
            this.txt_gioketthuc.Size = new System.Drawing.Size(184, 22);
            this.txt_gioketthuc.TabIndex = 13;
            // 
            // txt_ngaydat
            // 
            this.txt_ngaydat.Location = new System.Drawing.Point(433, 30);
            this.txt_ngaydat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ngaydat.Name = "txt_ngaydat";
            this.txt_ngaydat.Size = new System.Drawing.Size(184, 22);
            this.txt_ngaydat.TabIndex = 14;
            // 
            // txt_San
            // 
            this.txt_San.Location = new System.Drawing.Point(170, 126);
            this.txt_San.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_San.Name = "txt_San";
            this.txt_San.Size = new System.Drawing.Size(91, 22);
            this.txt_San.TabIndex = 15;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(473, 204);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(166, 22);
            this.txt_search.TabIndex = 16;
            // 
            // frm_LichSuDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 540);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_San);
            this.Controls.Add(this.txt_ngaydat);
            this.Controls.Add(this.txt_gioketthuc);
            this.Controls.Add(this.txt_giobatdau);
            this.Controls.Add(this.dtgv_lichsudatsan);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.DataGridView dtgv_lichsudatsan;
        private System.Windows.Forms.TextBox txt_giobatdau;
        private System.Windows.Forms.TextBox txt_gioketthuc;
        private System.Windows.Forms.TextBox txt_ngaydat;
        private System.Windows.Forms.TextBox txt_San;
        private System.Windows.Forms.TextBox txt_search;
    }
}