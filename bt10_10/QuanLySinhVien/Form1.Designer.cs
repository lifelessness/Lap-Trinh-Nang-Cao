namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            llblMaSV = new Label();
            txtMaSV = new TextBox();
            llblHoten = new Label();
            txtHoTen = new TextBox();
            ltxtNgaysinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblMaLop = new Label();
            txtMaLop = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // llblMaSV
            // 
            llblMaSV.AutoSize = true;
            llblMaSV.Location = new Point(47, 27);
            llblMaSV.Name = "llblMaSV";
            llblMaSV.Size = new Size(95, 20);
            llblMaSV.TabIndex = 0;
            llblMaSV.Text = "Mã Sinh Viên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(148, 24);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 1;
            // 
            // llblHoten
            // 
            llblHoten.AutoSize = true;
            llblHoten.Location = new Point(47, 63);
            llblHoten.Name = "llblHoten";
            llblHoten.Size = new Size(54, 20);
            llblHoten.TabIndex = 2;
            llblHoten.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(148, 57);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 3;
            // 
            // ltxtNgaysinh
            // 
            ltxtNgaysinh.AutoSize = true;
            ltxtNgaysinh.Location = new Point(47, 101);
            ltxtNgaysinh.Name = "ltxtNgaysinh";
            ltxtNgaysinh.Size = new Size(78, 20);
            ltxtNgaysinh.TabIndex = 4;
            ltxtNgaysinh.Text = "Ngày sinh ";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(147, 101);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(47, 145);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(150, 141);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(151, 28);
            cboGioiTinh.TabIndex = 7;
            cboGioiTinh.Text = "Nam";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(47, 181);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(60, 20);
            lblMaLop.TabIndex = 8;
            lblMaLop.Text = "Mã lớp ";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(148, 178);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 231);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(258, 231);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(464, 231);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(667, 231);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(47, 275);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(714, 188);
            dgvSinhVien.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMaLop);
            Controls.Add(lblMaLop);
            Controls.Add(cboGioiTinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(ltxtNgaysinh);
            Controls.Add(txtHoTen);
            Controls.Add(llblHoten);
            Controls.Add(txtMaSV);
            Controls.Add(llblMaSV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llblMaSV;
        private TextBox txtMaSV;
        private Label llblHoten;
        private TextBox txtHoTen;
        private Label ltxtNgaysinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private ComboBox cboGioiTinh;
        private Label lblMaLop;
        private TextBox txtMaLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvSinhVien;
    }
}
