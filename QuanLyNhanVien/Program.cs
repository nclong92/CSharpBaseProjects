using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien
{
    class Program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        static void TestQuanLyNhanVien()
        {
            PhongBan pNS = new PhongBan();
            pNS.MaPhongBan = 1;
            pNS.TenPhongBan = "Phòng Nhân Sự";
            dsPB.Add(pNS);

            NhanVien teo = new NhanVien();
            teo.MaNV = 1;
            teo.TenNhanVien = "Nguyễn Văn Tèo";
            teo.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pNS.ThemNhanVien(teo);

            NhanVien ty = new NhanVien();
            ty.MaNV = 2;
            ty.TenNhanVien = "Trần Thị Lý";
            ty.ChucVu = LoaiChucVu.NHAN_VIEN;
            pNS.ThemNhanVien(ty);

            PhongBan pkt = new PhongBan();
            pkt.MaPhongBan = 2;
            pkt.TenPhongBan = "Phòng Kế Toán";
            dsPB.Add(pkt);

            NhanVien bin = new NhanVien();
            bin.MaNV = 3;
            bin.TenNhanVien = "Bin bin bin";
            bin.ChucVu = LoaiChucVu.PHO_PHONG;
            pkt.ThemNhanVien(bin);

            Console.WriteLine("Danh sách toàn bộ nhân viên");

            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            NhanVien old = pkt.TimNhanVien(3);
            if (old != null)
                old.TenNhanVien = "Bim bim bim";

            Console.WriteLine("Danh sách toàn bộ nhân viên sau khi chỉnh sửa:");

            foreach (PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            if (!pNS.XoaNhanVien(113))
            {
                Console.WriteLine($"Không tìm thấy mã nhân viên =113.");
            }
            else
            {
                Console.WriteLine("Danh sách toàn bộ nhân viên sau khi xóa:");

                foreach(PhongBan pb in dsPB)
                {
                    Console.WriteLine(pb.TenPhongBan);
                    pb.XuatToanBoNhanVien();
                }
            }

            Console.WriteLine("Danh sách nhân viên thuộc phòng nhân sự:");
            pNS.XuatToanBoNhanVien();
            pNS.SapXep();
            Console.WriteLine("Danh sách nhân viên PNS sau khi sắp xếp:");
            pNS.XuatToanBoNhanVien();

            long sum = 0;
            foreach (PhongBan pb in dsPB)
                sum += pb.TongLuong();

            Console.WriteLine($"Tổng lương phải thanh toán 1 tháng là {sum}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestQuanLyNhanVien();
            Console.ReadLine();
        }
    }
}
