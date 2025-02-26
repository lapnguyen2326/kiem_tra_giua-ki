using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_giua_ki
{
    public class Giangvien
    {Console.OutputEncoding = Encoding.UTF8;
        // thuộc tính chung 
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public int Namsinh { get; set; }
        // Constructor mặc định và có tham số
        public Giangvien() { }

        public Giangvien(string maso, string hoten, int namsinh)
        {
            Maso = maso;
            Hoten = hoten;
            Namsinh = namsinh;
        }
        // Các phương thức ảo
        public virtual void Nhap()
        {
            Console.Write("Nhập mã số giảng viên: ");
            Maso = Console.ReadLine();
            Console.Write("Nhập họ tên giảng viên: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhập năm sinh giảng viên: ");
            Namsinh = int.Parse(Console.ReadLine());
        }
        public virtual int TinhLuong()
        {
            return 0; // Lương của giảng viên cơ bản là 0
        }
    }
}
