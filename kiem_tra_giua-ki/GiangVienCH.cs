using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_giua_ki
{
    internal class GiangVienCH : Giangvien
    {
        public float Hesoluong { get; set; }
        // Constructor mặc định và có tham số
        public GiangVienCH() { }
        public GiangVienCH(string maso, string hoten, int namsinh, float hesoluong)
        : base(maso, hoten, namsinh)
        {
            {
                Hesoluong = hesoluong;
            }
            // Ghi đè phương thức Nhap()
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập hệ số lương: ");
            Hesoluong = float.Parse(Console.ReadLine());
        }
        // Ghi đè phương thức TinhLuong()
        public override int TinhLuong()
        {
            return (int)(Hesoluong * 2340000);
        }
    }
}
