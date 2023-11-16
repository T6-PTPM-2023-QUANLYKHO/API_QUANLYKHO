using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IPhanQuyenRepository
    {
        public List<PhanQuyenModel> getAllPhanQuyen();
        public PhanQuyenModel getPhanQuyenById(string manhomngdung);
        public int AddPhanQuyen(PhanQuyenModel model);
        public int RemovePhanQuyen(string manhomngdung);
        public int UpdatePhanQuyen(PhanQuyenModel model);
    }
    public class PhanQuyenRepository : IPhanQuyenRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<PhanQuyenModel> getAllPhanQuyen()
        {
            string query = "SELECT * FROM QL_PHANQUYEN";
            DataTable tbl = con.getDataTable(query);
            List<PhanQuyenModel> lst = new List<PhanQuyenModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                PhanQuyenModel kh = new PhanQuyenModel(
                    tbl.Rows[i][0].ToString(), //manhomngdung
                      tbl.Rows[i][1].ToString(),//mamh
                      tbl.Rows[i][2].ToString()//coquyen
                                                );
                lst.Add(kh);
            }
            return lst;
        }
        public PhanQuyenModel getPhanQuyenById(string manhomngdung)
        {
            string query = "SELECT * FROM QL_PHANQUYEN where MANHOMNGUOIDUNG ='" + manhomngdung + "'";
            DataTable tbl = con.getDataTable(query);

            PhanQuyenModel kh = new PhanQuyenModel(
                      tbl.Rows[0][0].ToString(), //manhomngdung
                      tbl.Rows[0][1].ToString(),//mamh
                      tbl.Rows[0][2].ToString()//quyen
                                                 );
            return kh;
        }
        public int AddPhanQuyen(PhanQuyenModel model)
        {
            try
            {
                string query = "insert into QL_PHANQUYEN(MANHOMNGUOIDUNG,MAMANHINH,COQUYEN) values ('" + model.MA_NHOM_NGUOI_DUNG + "','" + model.MA_MAN_HINH + "','" + model.COQUYEN + "')";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemovePhanQuyen(string manhomngdung)
        {
            try
            {
                string query = "delete from QL_PHANQUYEN where MANHOMNGUOIDUNG ='" + manhomngdung + "'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdatePhanQuyen(PhanQuyenModel model)
        {
            try
            {
                RemovePhanQuyen(model.MA_NHOM_NGUOI_DUNG);
                AddPhanQuyen(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
