using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiem_tra_giua_ki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLyGV qlGV = new QuanLyGV();

            int choice;
            do
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Nhập danh sách giảng viên");
                Console.WriteLine("2. Hiển thị danh sách giảng viên");
                Console.WriteLine("3. Tính tổng tiền lương");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        qlGV.NhapDS();
                        break;
                    case 2:
                        qlGV.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tổng tiền lương cần trả: {qlGV.TinhTongLuong()}");
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            } while (choice != 4);
        }
    }
}
