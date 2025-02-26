using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_giua_ki
{
    internal class GiangVienTG : Giangvien
    {
        public int Sotietday { get; set; }
        // Constructor mặc định và có tham số
        public GiangVienTG() { }
        public GiangVienTG(string maso, string hoten, int namsinh, int sotietday)
        : base(maso, hoten, namsinh)
        {
            Sotietday = sotietday;
        }
        // Ghi đè phương thức Nhap()
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số tiết dạy: ");
            Sotietday = int.Parse(Console.ReadLine());
        }
        // Ghi đè phương thức TinhLuong()
        public override int TinhLuong()
        {
            return Sotietday * 120000;
        }
    }
}
