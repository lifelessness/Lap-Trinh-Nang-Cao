
using System;
using System.Windows.Forms;
using QuanLySinhVien.BUL;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private SinhVienBUL bul = new SinhVienBUL();

        public Form1()
        {
            InitializeComponent();

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("N?");

            dgvSinhVien.AutoGenerateColumns = true;
            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;

            HienThiDanhSach();

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void HienThiDanhSach()
        {
            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = bul.GetAllSinhVien();
        }

        private SinhVien LayDuLieu()
        {
            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = cboGioiTinh.Text,
                MaLop = txtMaLop.Text.Trim()
            };
        }

        private void XoaTrang()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtMaLop.Clear();
            cboGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Today;
            txtMaSV.ReadOnly = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bul.AddSinhVien(LayDuLieu());
                HienThiDanhSach();
                XoaTrang();

                MessageBox.Show("Thêm sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "L?i");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bul.UpdateSinhVien(LayDuLieu());
                HienThiDanhSach();
                XoaTrang();

                MessageBox.Show("C?p nh?t thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "L?i");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text))
                {
                    MessageBox.Show("Vui lòng ch?n sinh viên c?n xóa!");
                    return;
                }

                var result = MessageBox.Show(
                    "B?n có ch?c mu?n xóa sinh viên này?",
                    "Xác nh?n",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    bul.DeleteSinhVien(txtMaSV.Text.Trim());
                    HienThiDanhSach();
                    XoaTrang();

                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "L?i");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
            HienThiDanhSach();
        }

        private void dgvSinhVien_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SinhVien sv = dgvSinhVien.Rows[e.RowIndex]
                .DataBoundItem as SinhVien;

            if (sv == null)
                return;

            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            cboGioiTinh.Text = sv.GioiTinh;
            txtMaLop.Text = sv.MaLop;

            txtMaSV.ReadOnly = true;
        }
    }
}

