using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranNguyenTienThy_02_2321160029
{
    class NhanVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public int LuongCung { get; set; }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap luong cung: ");
            LuongCung = int.Parse(Console.ReadLine());
        }
        public virtual int TinhLuong()
        {
            return LuongCung;
        }
    }
    class NhanVienBienChe : NhanVien
    {
        public string MucXepLoai { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai (A, B, C): ");
            MucXepLoai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            int thuong = 0;
            switch (MucXepLoai)
            {
                case "A":
                    thuong = (int)(1.5 * LuongCung);
                    break;
                case "B":
                    thuong = (int)(1.0 * LuongCung);
                    break;
                case "C":
                    thuong = (int)(0.5 * LuongCung);
                    break;
            }
            return LuongCung + thuong;
        }

    }
    class NhanVienHopDong : NhanVien
    {
        public int DoanhThu { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doanh thu: ");
            DoanhThu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            return LuongCung +(int)(0.1*DoanhThu);
        }
    }
    class QuanLyNhanVien
    {
        public List<NhanVien> dsNV { get; set; }
        public QuanLyNhanVien()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin nhan vien thu {i + 1}: ");
                Console.WriteLine("Chon loai nhan vien");
                Console.WriteLine("\t1: - Bien che");
                Console.WriteLine("\t2: - Hop dong");
                int luaChon = int.Parse(Console.ReadLine());
                switch(luaChon)
                {
                    case 1: 
                        NhanVienBienChe nvbc = new NhanVienBienChe();
                        nvbc.Nhap();
                        dsNV.Add(nvbc);
                        break;
                    case 2:
                        NhanVienHopDong nvhd = new NhanVienHopDong();
                        nvhd.Nhap();
                        dsNV.Add(nvhd);
                        break;
                    default:
                        Console.WriteLine("Lua chon cua ban khong hop le!");
                        break;
                }
            }while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        public void XuatDS()
        {
            foreach (var nv in dsNV)
            {
                Console.WriteLine($"Ma so nhan vien: {nv.MaSo} \t Ho ten: {nv.HoTen} \t Luong: {nv.TinhLuong()}");
            }    
        }
        public int TinhTongLuong()
        {
            int tongLuong = 0;
            foreach(var nv in dsNV)
            {
                tongLuong += nv.TinhLuong();
            }
            return tongLuong;
        }
        public double TinhLuongTrungBinh()
        {
            if (dsNV.Count == 0)
                return 0;
            double tongLuong = TinhTongLuong();
            return tongLuong / dsNV.Count;
        }
    }
}
