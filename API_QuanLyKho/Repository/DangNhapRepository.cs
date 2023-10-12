using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IDangNhapRepository
    {
        public List<DangNhapModel> getAllDangNhap();
        public DangNhapModel getDangNhapById(string taikhoandn);
        public int AddDangNhap(DangNhapModel model);
        public int RemoveDangNhap(string taikhoandn);
        public int UpdateDangNhap(DangNhapModel model);
    }
    public class DangNhapRepository : IDangNhapRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<DangNhapModel> getAllDangNhap()
        {
            string query = "SELECT * FROM DANGNHAP";
            DataTable tbl = con.getDataTable(query);
            List<DangNhapModel> lst = new List<DangNhapModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DangNhapModel kh = new DangNhapModel(
                    tbl.Rows[i][0].ToString(), //taikhoandn
                      tbl.Rows[i][1].ToString()//mk
                                                );
                lst.Add(kh);
            }
            return lst;
        }
        public DangNhapModel getDangNhapById(string taikhoandn)
        {
            string query = "SELECT * FROM DANGNHAP where TAIKHOAN ='" + taikhoandn + "'";
            DataTable tbl = con.getDataTable(query);

            DangNhapModel kh = new DangNhapModel(
                      tbl.Rows[0][0].ToString(), //taikhoandn
                      tbl.Rows[0][1].ToString()//mk
                                                 );
            return kh;
        }
        public int AddDangNhap(DangNhapModel model)
        {
            try
            {
                string query = "insert into DANGNHAP(TAIKHOAN,MATKHAU) values ('" + model.TAI_KHOAN + "','" + model.TAI_KHOAN + "')";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemoveDangNhap(string taikhoandn)
        {
            try
            {
                string query = "delete from DANGNHAP where TAIKHOAN ='" + taikhoandn + "'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdateDangNhap(DangNhapModel model)
        {
            try
            {
                RemoveDangNhap(model.TAI_KHOAN);
                AddDangNhap(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
