using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien
{
    public class NhanVien
    {
        public static long LUONG_CO_BAN = 10000000;
        public int MaNV { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public LoaiChucVu ChucVu { get; set; }
        public PhongBan Phong { get; set; }

        public long TinhLuong
        {
            get
            {
                if (ChucVu == LoaiChucVu.GIAM_DOC)
                    return (long) (LUONG_CO_BAN * 1.25);
                if (ChucVu == LoaiChucVu.TRUONG_PHONG)
                    return (long)(LUONG_CO_BAN * 1.15);
                if (ChucVu == LoaiChucVu.PHO_PHONG)
                    return (long)(LUONG_CO_BAN * 1.05);
                return LUONG_CO_BAN;
            }
        }

        public override string ToString()
        {
            return this.MaNV + "\t"
                + this.TenNhanVien + "\t"
                + this.ChucVu + "\t ==>"
                + this.TinhLuong;
        }
    }
}
