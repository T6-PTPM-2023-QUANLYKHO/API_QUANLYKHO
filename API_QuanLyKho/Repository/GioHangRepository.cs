using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using Newtonsoft.Json;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IGioHangRepository
    {
        public List<GioHangModel> getByMaKH(string  maKH);
        public int ThemGioHang(GioHangModel t);
        public int xoaGioHang(string MaKH, string MaSP);
        public int CapNhatGioHang(GioHangModel gh);
    }
    public class GioHangRepository:IGioHangRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<GioHangModel> getByMaKH(string maKH)
        {
            try
            {
                string query = "select * from  GIOHANG where MAKH ='" + maKH + "'";
                DataTable tbl = con.getDataTable(query);
                string json = JsonConvert.SerializeObject(tbl);
                List<GioHangModel> result = JsonConvert.DeserializeObject<List<GioHangModel>>(json);
                return result;
            }
            catch { return null; }
           
        }
        public int ThemGioHang(GioHangModel t)
        {
            try
            {
                string query = "insert into GIOHANG values ('" + t.MaSanPham + "','" + t.MAKH + "',N'" + t.TenSP + "'," + t.SoLuong + "," + t.DonGia + ")";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int xoaGioHang(string MaKH, string MaSP)
        {
            try
            {

                string query = "delete GIOHANG where MaSanPham='" + MaSP + "' and MAKH='" + MaKH + "'";
                return 1;
            }
            catch { return 0; }
        }
        public int CapNhatGioHang(GioHangModel gh)
        {
            string query = "update GIOHANG set MaSanPham='"+gh.MaSanPham+"', MAKH ='"+gh.MAKH+"', TenSP =N'"+gh.TenSP+"', SoLuong = "+gh.SoLuong+", DonGia ="+gh.DonGia+"";
            con.updateToDatabase(query);
            return 1;
        }
    }
}
