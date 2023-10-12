namespace API_QuanLyKho.Hepper
{
    public class WebEndpoint
    {
        public const string AreaName = "api";
        public static class ChiTietXH
        {
            private const string BaseEndpoint = "~/" + AreaName + "/chi-tiet-xuat-hang";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{maphxh}";
            public const string GET_ITEM_BY_ID = BaseEndpoint + "/get-by-item-id/{maphxh}/{masp}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_CTMAPHIEUXH = BaseEndpoint + "/remove-by-maphieu/{maphxh}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{maphxh}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{maphxh}";
        }
        public static class PhieuXuatHang
        {
            private const string BaseEndpoint = "~/" + AreaName + "/phieu-xuat-hang";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MAPHIEUXH = BaseEndpoint + "/remove-by-maphieuxh/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        public static class KhachHang
        {
            private const string BaseEndpoint = "~/" + AreaName + "/khach-hang";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MAKHACHHANG = BaseEndpoint + "/remove-by-ma-khach-hang/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        public static class LoaiSP
        {
            private const string BaseEndpoint = "~/" + AreaName + "/loai-sp";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MALOAISP= BaseEndpoint + "/remove-by-ma-loai-Sp/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        public static class SanPham
        {
            private const string BaseEndpoint = "~/" + AreaName + "/San-pham";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MASP = BaseEndpoint + "/remove-by-ma-San-Pham/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        public static class Khu
        {
            private const string BaseEndpoint = "~/" + AreaName + "/Khu";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MAKHU = BaseEndpoint + "/remove-by-ma-khu/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        public static class KhoHang
        {
            private const string BaseEndpoint = "~/" + AreaName + "/KhoHang";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MAKHO = BaseEndpoint + "/remove-by-ma-kho/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        public static class KeSP
        {
            private const string BaseEndpoint = "~/" + AreaName + "/ke";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{id}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MAKE = BaseEndpoint + "/remove-by-ma-ke/{id}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update";
        }
        //Sang
        public static class ChiTietNH
        {
            private const string BaseEndpoint = "~/" + AreaName + "/chi-tiet-nhap-hang";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{maphieunh}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_CTMAPHIEUNH = BaseEndpoint + "/remove-by-maphieu/{maphieunh}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{maphieunh}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{maphieunh}";
        }
        public static class ChucVu
        {
            private const string BaseEndpoint = "~/" + AreaName + "/chuc-vu";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{machucvu}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_CHUCVU = BaseEndpoint + "/remove-by-maphieu/{machucvu}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{machucvu}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{machucvu}";
        }
        public static class NhaCungCap
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nha-cung-cap";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{manhacungcap}";
            public const string GET_BY_SDT = BaseEndpoint + "/get-by-sdt/{sdtnhacungcap}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_NHACUNGCAP = BaseEndpoint + "/remove-by-maphieu/{manhacungcap}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{manhacungcap}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{manhacungcap}";
        }
        public static class NhanVien
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nhan-vien";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{manhanvien}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_NHANVIEN = BaseEndpoint + "/remove-by-maphieu/{manhanvien}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{manhanvien}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{manhanvien}";
        }
        public static class PhieuNhapHang
        {
            private const string BaseEndpoint = "~/" + AreaName + "/phieu-nhap-hang";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{maphieunhaphang}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_PHIEUNHAPHANG = BaseEndpoint + "/remove-by-maphieu/{maphieunhaphang}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{maphieunhaphang}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{maphieunhaphang}";
        }
        //Tuan
        public static class PhanQuyen
        {
            private const string BaseEndpoint = "~/" + AreaName + "/phan-quyen";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{manhomnguoidung}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MaNhomNguoiDung = BaseEndpoint + "/remove-by-manhomnguoidung/{id}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{manhomnguoidung}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{manhomnguoidung}";
        }
        public static class NhomNguoiDung
        {
            private const string BaseEndpoint = "~/" + AreaName + "/nhom-nguoi-dung";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{manhom}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_MaNhom = BaseEndpoint + "/remove-by-manhom/{id}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{manhom}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{manhom}";
        }
        public static class TaiKhoanNV
        {
            private const string BaseEndpoint = "~/" + AreaName + "/tai-khoan";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{taikhoan}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_TaiKhoan = BaseEndpoint + "/remove-by-taikhoan/{id}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{taikhoan}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{taikhoan}";
        }
        public static class DangNhap
        {
            private const string BaseEndpoint = "~/" + AreaName + "/tai-khoan-dn";
            public const string GET_ALL = BaseEndpoint + "/get-all";
            public const string GET_BY_ID = BaseEndpoint + "/get-by-id/{taikhoan-dn}";
            public const string ADD_ITEM = BaseEndpoint + "/add-item";
            public const string REMOVE_BY_TaiKhoanDN = BaseEndpoint + "/remove-by-taikhoan-dn/{id}";
            public const string REMOVE_ITEM = BaseEndpoint + "/remove/{taikhoan-dn}";
            public const string UPDATE_ITEM = BaseEndpoint + "/update/{taikhoan-dn}";
        }
    }
}
