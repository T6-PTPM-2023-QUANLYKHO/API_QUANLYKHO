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
    }
}
