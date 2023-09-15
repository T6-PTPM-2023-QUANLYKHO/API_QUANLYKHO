using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IKhachHangRepository
    {
        public List<KhachHangModel> getAllKhachHang();
        public KhachHangModel getKhachHangById(string makh);
        public int AddKhachHang(KhachHangModel model);
        public int RemoveKhachHang(string makh );
        public int UpdateKhachHang(KhachHangModel model);
    }
    public class KhachHangRepository: IKhachHangRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<KhachHangModel> getAllKhachHang()
        {
            string query = "SELECT * FROM KHACH_HANG";
            DataTable tbl = con.getDataTable(query);
            List<KhachHangModel> lst = new List<KhachHangModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                KhachHangModel kh = new KhachHangModel(
                    tbl.Rows[i][0].ToString(), //makh
                      tbl.Rows[i][1].ToString(),//tenkh
                      tbl.Rows[i][2].ToString(),//dia chi 
                      tbl.Rows[i][3].ToString(), //gioitinh
                      tbl.Rows[i][4].ToString(), //sdt
                      tbl.Rows[i][5].ToString(),//email
                      tbl.Rows[i][6].ToString() //fax
                                                );
                lst.Add(kh);
            }
            return lst;
        }
        public KhachHangModel getKhachHangById(string makh)
        {
            string query = "SELECT * FROM KHACH_HANG where MAKH ='"+makh+"'";
            DataTable tbl = con.getDataTable(query);

            KhachHangModel kh = new KhachHangModel(
                     tbl.Rows[0][0].ToString(), //makh
                       tbl.Rows[0][1].ToString(),//tenkh
                       tbl.Rows[0][2].ToString(),//dia chi 
                       tbl.Rows[0][3].ToString(), //gioitinh
                       tbl.Rows[0][4].ToString(), //sdt
                       tbl.Rows[0][5].ToString(),//email
                       tbl.Rows[0][6].ToString() //fax
                                                 );
            return kh;
        }
        public int AddKhachHang(KhachHangModel model)
        {
            try
            {
                string query = "insert into KHACH_HANG(MAKH, TEN_KH, DIACHI_KH,GIOITINH_KH,SDT_KH,EMAIL_KH,FAX) values ('"+model.MAKH+"',N'"+model.TEN_KH+"',N'"+model.DIACHI_KH+"',N'"+model.GIOITINH_KH+"','"+model.SDT_KH+"','"+model.EMAIL_KH+"','"+model.FAX+"')";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemoveKhachHang(string makh)
        {
            try
            {
                string query = "delete from KHACH_HANG where MAKH ='"+makh+"'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdateKhachHang(KhachHangModel model)
        {
            try
            {
                RemoveKhachHang(model.MAKH);
                AddKhachHang(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
