
using QuanLySinhVien.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Data.DAL
{
    public class SinhVienDAL
    {
        private readonly List<SinhVien> sinhViens =
            new List<SinhVien>();

        public SinhVienDAL()
        {
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV0001",
                HoTen = "Nguyễn Văn A",
                NgaySinh = new DateTime(2000, 1, 1),
                GioiTinh = "Nam",
                MaLop = "CSE0001"
            });

            sinhViens.Add(new SinhVien
            {
                MaSV = "SV0002",
                HoTen = "Trần Thị B",
                NgaySinh = new DateTime(2000, 2, 2),
                GioiTinh = "Nữ",
                MaLop = "CSE0002"
            });

            sinhViens.Add(new SinhVien
            {
                MaSV = "SV0003",
                HoTen = "Lê Văn C",
                NgaySinh = new DateTime(2000, 3, 3),
                GioiTinh = "Nam",
                MaLop = "CSE0003"
            });
        }

        public SinhVien GetSinhVienByMaSV(string maSV)
        {
            return sinhViens.FirstOrDefault(
                s => s.MaSV == maSV
            );
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop)
        {
            return sinhViens
                .Where(s => s.MaLop == maLop)
                .ToList();
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return sinhViens.ToList();
        }

        public void AddSinhVien(SinhVien sv)
        {
            if (GetSinhVienByMaSV(sv.MaSV) != null)
            {
                throw new Exception("Mã sinh viên đã tồn tại!");
            }

            sinhViens.Add(sv);
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            SinhVien sinhVienCu = GetSinhVienByMaSV(sv.MaSV);

            if (sinhVienCu == null)
            {
                throw new Exception("Không tìm thấy sinh viên!");
            }

            sinhVienCu.HoTen = sv.HoTen;
            sinhVienCu.NgaySinh = sv.NgaySinh;
            sinhVienCu.GioiTinh = sv.GioiTinh;
            sinhVienCu.MaLop = sv.MaLop;
        }

        public void DeleteSinhVien(string maSV)
        {
            SinhVien sv = GetSinhVienByMaSV(maSV);

            if (sv == null)
            {
                throw new Exception("Không tìm thấy sinh viên!");
            }

            sinhViens.Remove(sv);
        }
    }
}
