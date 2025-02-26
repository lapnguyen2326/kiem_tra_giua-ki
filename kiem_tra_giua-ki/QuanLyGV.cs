using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_giua_ki
{
    internal class QuanLyGV
    {
        public List<Giangvien> DsGV { get; set; }
        // Constructor mặc định
        public QuanLyGV()
        {
            DsGV = new List<Giangvien>();
        }
        // Phương thức nhập danh sách giảng viên
        public void NhapDS()
        {
            int n;
            Console.Write("Nhập số lượng giảng viên: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chọn loại giảng viên:");
                Console.WriteLine("1. Giảng viên cơ hữu");
                Console.WriteLine("2. Giảng viên thỉnh giảng");
                int loaiGV = int.Parse(Console.ReadLine());
                Giangvien gv = null;
                if (loaiGV == 1)
                {
                    gv = new GiangVienCH();
                }
                else if (loaiGV == 2)
                {
                    gv = new GiangVienTG();
                }
                gv.Nhap();
                DsGV.Add(gv);
            }
        }
        // Phương thức xuất danh sách giảng viên
        public void XuatDS()
        {
            foreach (var gv in DsGV)
            {
                Console.WriteLine($"Mã số: {gv.Maso}, Họ tên: {gv.Hoten}, Năm sinh: {gv.Namsinh}, Lương: {gv.TinhLuong()}");
            }
        }
        // Phương thức tính tổng lương
        public int TinhTongLuong()
        {
            int tongLuong = 0;
            foreach (var gv in DsGV)
            {
                tongLuong += gv.TinhLuong();
            }
            return tongLuong;
        }
    }
}
