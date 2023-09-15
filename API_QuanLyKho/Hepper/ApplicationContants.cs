namespace API_QuanLyKho.Hepper
{
    public static class ApplicationContants
    {
        public static class ResponseCodeConstants
        {
            public const string NOT_FOUND = "Not found!";
            public const string SUCCESS = "Success!";
            public const string FAILED = "Failed!";
            public const string EXISTED = "Existed!";
        }
        public class ReponseMessageConstantsChiTietPhieuXuat
        {
            public const string NOT_FOUND_ChiTietPhieuXuat = "Khong tim thay Chi Tiet Phieu Xuat.";
            public const string EXISTED_ChiTietPhieuXuat = "Chi Tiet Phieu Xuat da ton tai.";
            public const string UPDATE_ChiTietPhieuXuat_SUCCESS = "Cap nhat Chi Tiet Phieu Xuat thanh cong.";
            public const string DELETE_ChiTietPhieuXuat_SUCCESS = "Xoa Chi Tiet Phieu Xuat thanh cong.";
        }
        public class ReponseMessageConstantsPhieuXuatHang
        {
            public const string NOT_FOUND_PhieuXuatHang = "Khong tim thay phieu xuat hang.";
            public const string EXISTED_PhieuXuatHang = "phieu xuat hang da ton tai.";
            public const string UPDATE_PhieuXuatHang_SUCCESS = "Cap nhat phieu xuat hang thanh cong.";
            public const string DELETE_PhieuXuatHang_SUCCESS = "Xoa phieu xuat hang thanh cong.";
        }
        public class ReponseMessageConstantsKhachHang
        {
            public const string NOT_FOUND_KhachHang = "Khong tim thay khach hang.";
            public const string EXISTED_KhachHang = "khach hang da ton tai.";
            public const string UPDATE_KhachHang_SUCCESS = "Cap nhat khach hang thanh cong.";
            public const string DELETE_KhachHang_SUCCESS = "Xoa khach hang thanh cong.";
        }
    }    
}
