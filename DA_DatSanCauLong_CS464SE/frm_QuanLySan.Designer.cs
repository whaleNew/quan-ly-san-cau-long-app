namespace DA_DatSanCauLong_CS464SE
{
    partial class frm_QuanLySan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLySan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_maSan = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_giaSan = new System.Windows.Forms.TextBox();
            this.txt_tenSan = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.dtgr_SanCau = new System.Windows.Forms.DataGridView();
            this.pic_Hinhanh = new System.Windows.Forms.PictureBox();
            this.btn_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_SanCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(367, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản Lý Sân Cầu Lông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sân:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá sân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái:";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(125, 403);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(122, 47);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_maSan
            // 
            this.txt_maSan.Location = new System.Drawing.Point(269, 111);
            this.txt_maSan.Name = "txt_maSan";
            this.txt_maSan.Size = new System.Drawing.Size(294, 22);
            this.txt_maSan.TabIndex = 6;
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(269, 276);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(294, 22);
            this.txt_Status.TabIndex = 7;
            // 
            // txt_giaSan
            // 
            this.txt_giaSan.Location = new System.Drawing.Point(269, 222);
            this.txt_giaSan.Name = "txt_giaSan";
            this.txt_giaSan.Size = new System.Drawing.Size(294, 22);
            this.txt_giaSan.TabIndex = 8;
            // 
            // txt_tenSan
            // 
            this.txt_tenSan.Location = new System.Drawing.Point(269, 164);
            this.txt_tenSan.Name = "txt_tenSan";
            this.txt_tenSan.Size = new System.Drawing.Size(294, 22);
            this.txt_tenSan.TabIndex = 9;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(330, 403);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(122, 47);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(544, 403);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(122, 47);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fresh.Location = new System.Drawing.Point(773, 403);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(122, 47);
            this.btn_Fresh.TabIndex = 12;
            this.btn_Fresh.Text = "Làm Mới";
            this.btn_Fresh.UseVisualStyleBackColor = true;
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // dtgr_SanCau
            // 
            this.dtgr_SanCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr_SanCau.Location = new System.Drawing.Point(96, 482);
            this.dtgr_SanCau.Name = "dtgr_SanCau";
            this.dtgr_SanCau.RowHeadersWidth = 51;
            this.dtgr_SanCau.RowTemplate.Height = 24;
            this.dtgr_SanCau.Size = new System.Drawing.Size(892, 180);
            this.dtgr_SanCau.TabIndex = 13;
            this.dtgr_SanCau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgr_SanCau_CellClick);
            // 
            // pic_Hinhanh
            // 
            this.pic_Hinhanh.Image = ((System.Drawing.Image)(resources.GetObject("pic_Hinhanh.Image")));
            this.pic_Hinhanh.Location = new System.Drawing.Point(675, 105);
            this.pic_Hinhanh.Name = "pic_Hinhanh";
            this.pic_Hinhanh.Size = new System.Drawing.Size(338, 251);
            this.pic_Hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Hinhanh.TabIndex = 16;
            this.pic_Hinhanh.TabStop = false;
            // 
            // btn_Image
            // 
            this.btn_Image.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Image.Location = new System.Drawing.Point(544, 329);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(114, 27);
            this.btn_Image.TabIndex = 17;
            this.btn_Image.Text = "Chọn Ảnh";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // frm_QuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 698);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.pic_Hinhanh);
            this.Controls.Add(this.dtgr_SanCau);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_tenSan);
            this.Controls.Add(this.txt_giaSan);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_maSan);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_QuanLySan";
            this.Text = "frm_QuanLySan";
            this.Load += new System.EventHandler(this.frm_QuanLySan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_SanCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_maSan;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_giaSan;
        private System.Windows.Forms.TextBox txt_tenSan;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.DataGridView dtgr_SanCau;
        private System.Windows.Forms.PictureBox pic_Hinhanh;
        private System.Windows.Forms.Button btn_Image;
    }
}