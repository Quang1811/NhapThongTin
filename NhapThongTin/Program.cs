using System;

namespace NhapThongTin
{
    class Program
{
    static void Main(string[] args)
    {
        string HoTen;
        DateTime NgaySinh;
        int Tuoi;
        Console.Write(" nhap Ho Ten: ");
        HoTen = Console.ReadLine();
        Console.WriteLine(HoTen);
        Console.Write(" nhap Ngay Sinh: ");
        NgaySinh = DateTime.Parse(Console.ReadLine());
        Tuoi = DateTime.Today.Year - NgaySinh.Year;
        string chuoi = "Tuoi:" + Tuoi;
        Console.Write(chuoi);
        Console.ReadLine();
    }
}
}