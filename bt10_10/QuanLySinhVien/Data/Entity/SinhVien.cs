
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public string MaSV { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100, ErrorMessage = "Họ tên tối đa 100 ký tự")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Ngày sinh không hợp lệ")]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Mã lớp không được để trống")]
        public string MaLop { get; set; }

        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);

            Validator.TryValidateObject(
                this,
                context,
                results,
                validateAllProperties: true
            );

            if (NgaySinh.Date > DateTime.Today)
            {
                results.Add(new ValidationResult(
                    "Ngày sinh không được lớn hơn ngày hiện tại"
                ));
            }

            return results;
        }
    }
}
