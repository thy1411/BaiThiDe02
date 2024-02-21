using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranNguyenTienThy_02_2321160029
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            int luaChon;
            do
            {
                Console.WriteLine("_______________ MENU _______________");
                Console.WriteLine("1. Nhap danh sach nhan vien");
                Console.WriteLine("2. Hien thi thong tin cac nhan vien");
                Console.WriteLine("3. Thong ke tong tien luong cong ty");
                Console.WriteLine("4. Tinh tien luong trung binh cua cac nhan vien");
                Console.WriteLine("5. Thoat menu");
                Console.WriteLine();
                Console.WriteLine("Vui long nhap lua chon cua ban!");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        qlnv.NhapDS();
                        break;
                    case 2:
                        qlnv.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong cua cong ty phai tra: {qlnv.TinhLuongTrungBinh()}");
                        break;
                    case 4:
                        Console.WriteLine($"Tien luong trung binh cua cac nhan vien: {qlnv.TinhLuongTrungBinh()}");
                        break;
                    case 5:
                        Console.WriteLine("Ban da thoat menu!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai");
                        break;
                }
            } while (luaChon != 5);
        }
    }
}
