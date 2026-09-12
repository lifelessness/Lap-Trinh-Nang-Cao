using System;
using System.Collections.Generic;

public interface IHinh
{
    double GetDienTich();
    double GetChuVi();
    void Nhap();
    void HienThi();
}

public static class ConsoleHelper
{
    // Hàm hỗ trợ nhập số thực dương an toàn
    public static double ReadPositiveDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value > 0)
            {
                return value;
            }
            Console.WriteLine("Giá trị không hợp lệ! Vui lòng nhập số thực lớn hơn 0.");
        }
    }
}

public class HinhTron : IHinh
{
    private double banKinh;

    public double BanKinh
    {
        get => banKinh;
        set => banKinh = value > 0 ? value : throw new ArgumentException("Bán kính phải lớn hơn 0.");
    }

    public void Nhap()
    {
        banKinh = ConsoleHelper.ReadPositiveDouble("Nhập bán kính hình tròn: ");
    }

    public double GetDienTich() => Math.PI * banKinh * banKinh;
    public double GetChuVi() => 2 * Math.PI * banKinh;

    public void HienThi()
    {
        Console.WriteLine($"[Hình Tròn] Bán kính: {banKinh:F2} | Chu vi: {GetChuVi():F2} | Diện tích: {GetDienTich():F2}");
    }
}

public class HinhChuNhat : IHinh
{
    public double ChieuDai { get; private set; }
    public double ChieuRong { get; private set; }

    public void Nhap()
    {
        ChieuDai = ConsoleHelper.ReadPositiveDouble("Nhập chiều dài: ");
        ChieuRong = ConsoleHelper.ReadPositiveDouble("Nhập chiều rộng: ");
    }

    public double GetDienTich() => ChieuDai * ChieuRong;
    public double GetChuVi() => (ChieuDai + ChieuRong) * 2;

    public void HienThi()
    {
        Console.WriteLine($"[Hình Chữ Nhật] Dài: {ChieuDai:F2}, Rộng: {ChieuRong:F2} | Chu vi: {GetChuVi():F2} | Diện tích: {GetDienTich():F2}");
    }
}

public class HinhTamGiac : IHinh
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    private static bool IsTamGiacValid(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public void Nhap()
    {
        while (true)
        {
            A = ConsoleHelper.ReadPositiveDouble("Nhập cạnh a: ");
            B = ConsoleHelper.ReadPositiveDouble("Nhập cạnh b: ");
            C = ConsoleHelper.ReadPositiveDouble("Nhập cạnh c: ");

            if (IsTamGiacValid(A, B, C))
            {
                break;
            }
            Console.WriteLine("Ba cạnh không thỏa mãn bất đẳng thức tam giác! Vui lòng nhập lại.\n");
        }
    }

    public double GetChuVi() => A + B + C;

    public double GetDienTich()
    {
        double p = GetChuVi() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public void HienThi()
    {
        Console.WriteLine($"[Hình Tam Giác] Các cạnh: {A:F2}, {B:F2}, {C:F2} | Chu vi: {GetChuVi():F2} | Diện tích: {GetDienTich():F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<IHinh> danhSachHinh = new List<IHinh>
        {
            new HinhTron(),
            new HinhChuNhat(),
            new HinhTamGiac()
        };

        Console.WriteLine("=== NHẬP THÔNG TIN CÁC HÌNH ===");
        foreach (var hinh in danhSachHinh)
        {
            Console.WriteLine();
            hinh.Nhap();
        }

        Console.WriteLine("\n=== KẾT QUẢ TÍNH TOÁN (ĐA HÌNH) ===");
        foreach (var hinh in danhSachHinh)
        {
            hinh.HienThi();
        }
    }
}