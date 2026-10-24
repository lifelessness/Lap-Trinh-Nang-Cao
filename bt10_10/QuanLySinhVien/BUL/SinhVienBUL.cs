
using QuanLySinhVien.Data.DAL;
using QuanLySinhVien.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QuanLySinhVien.BUL
{
    public class SinhVienBUL
    {
        private readonly SinhVienDAL svd;

        public SinhVienBUL()
        {
            svd = new SinhVienDAL();
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return svd.GetAllSinhVien();
        }

        public SinhVien GetSinhVienByMaSV(string maSV)
        {
            return svd.GetSinhVienByMaSV(maSV);
        }

        public List<SinhVien> GetSinhVienByMaLop(string maLop)
        {
            return svd.GetSinhViensByMaLop(maLop);
        }

        private void KiemTraVaChuanHoa(SinhVien sv)
        {
            if (sv == null)
                throw new Exception("Thông tin sinh viên không hợp lệ!");

            sv.MaSV = (sv.MaSV ?? "").Trim();
            sv.HoTen = (sv.HoTen ?? "").Trim();
            sv.GioiTinh = (sv.GioiTinh ?? "").Trim();
            sv.MaLop = (sv.MaLop ?? "").Trim();

            sv.HoTen = Regex.Replace(sv.HoTen, @"\s+", " ");

            var errors = sv.IsInValid();

            if (errors.Count > 0)
            {
                throw new Exception(
                    string.Join(
                        Environment.NewLine,
                        errors.Select(e => e.ErrorMessage)
                    )
                );
            }
        }

        public void AddSinhVien(SinhVien sv)
        {
            KiemTraVaChuanHoa(sv);
            svd.AddSinhVien(sv);
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            KiemTraVaChuanHoa(sv);
            svd.UpdateSinhVien(sv);
        }

        public void DeleteSinhVien(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new Exception("Vui lòng nhập mã sinh viên!");

            svd.DeleteSinhVien(maSV.Trim());
        }
    }
}
