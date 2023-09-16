using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;


namespace API_QuanLyKho.Repository
{
    public interface ISanPhamRepository
    {
        public List<SanPhamModel> getAllSanPham();
        public SanPhamModel getSanPhamById(string masp);
        public int AddSanPham(SanPhamModel model);
        public int RemoveSanPham(string masp);
        public int UpdateSanPham(SanPhamModel model);
    }
    public class SanPhamRepository : ISanPhamRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<SanPhamModel> getAllSanPham()
        {
            string query = "SELECT * FROM SAN_PHAM";
            DataTable tbl = con.getDataTable(query);
            List<SanPhamModel> lst = new List<SanPhamModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                SanPhamModel Lsp = new SanPhamModel(
                tbl.Rows[i][0].ToString(), // MA_SP
                tbl.Rows[i][1].ToString(), // MA_NCC
                tbl.Rows[i][2].ToString(), // TEN_SP
                Convert.ToDateTime(tbl.Rows[i][3]), // NGAYSX (chuyển đổi thành kiểu DateTime)
                Convert.ToDateTime(tbl.Rows[i][4]), // HSD (chuyển đổi thành kiểu DateTime)
                Convert.ToInt32(tbl.Rows[i][5]), // SOLUONG (chuyển đổi thành kiểu int)
                tbl.Rows[i][6].ToString(), // MA_LOAI
                Convert.ToInt32(tbl.Rows[i][7]), // GIA (chuyển đổi thành kiểu int)
                tbl.Rows[i][8].ToString(), // GHICHU_SP
                tbl.Rows[i][9].ToString(), // MAKHO
                tbl.Rows[i][10] == DBNull.Value ? null : (byte[])tbl.Rows[i][10] // ANH (kiểm tra giá trị null)
                                                );
                lst.Add(Lsp);
            }
            return lst;
        }
        public SanPhamModel getSanPhamById(string masp)
        {
            string query = "SELECT * FROM SAN_PHAM where MA_SP ='" + masp + "'";
            DataTable tbl = con.getDataTable(query);
            SanPhamModel Lsp = new SanPhamModel(
                tbl.Rows[0][0].ToString(), // MA_SP
                tbl.Rows[0][1].ToString(), // MA_NCC
                tbl.Rows[0][2].ToString(), // TEN_SP
                Convert.ToDateTime(tbl.Rows[0][3]), // NGAYSX (chuyển đổi thành kiểu DateTime)
                Convert.ToDateTime(tbl.Rows[0][4]), // HSD (chuyển đổi thành kiểu DateTime)
                Convert.ToInt32(tbl.Rows[0][5]), // SOLUONG (chuyển đổi thành kiểu int)
                tbl.Rows[0][6].ToString(), // MA_LOAI
                Convert.ToInt32(tbl.Rows[0][7]), // GIA (chuyển đổi thành kiểu int)
                tbl.Rows[0][8].ToString(), // GHICHU_SP
                tbl.Rows[0][9].ToString(), // MAKHO
                (byte[])tbl.Rows[0][10] // ANH (chuyển đổi thành kiểu byte[])
                                                 );
            return Lsp;
        }
        public int AddSanPham(SanPhamModel model)
        {
            try
            {
                string query = "insert into SAN_PHAM (MA_SP, MA_NCC, TEN_SP, NGAYSX, HSD, SOLUONG_SP, MALOAI, GIA, GHICHU_SP, MAKHO, ANH) " +
                "values ('" + model.MA_SP + "', '" + model.MA_NCC + "', N'" + model.TEN_SP + "', '" + model.NGAYSX.ToString("yyyy-MM-dd") + "', '" + model.HSD.ToString("yyyy-MM-dd") + "', " + model.SOLUONG + ", '" + model.MA_LOAI + "', " + model.GIA + ", N'" + model.GHICHU_SP + "', '" + model.MAKHO + "', '" + model.ANH + "')";

                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemoveSanPham(string masp)
        {
            try
            {
                string query = "delete from SAN_PHAM where MA_SP ='" + masp + "'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdateSanPham(SanPhamModel model)
        {
            try
            {
                RemoveSanPham(model.MA_SP);
                AddSanPham(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
