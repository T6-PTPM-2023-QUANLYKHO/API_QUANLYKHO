using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IKeSPRepository
    {
        public List<KeSPModel> getAllKeSP();
        public KeSPModel getKeSPById(string make);
        public int AddKeSP(KeSPModel model);
        public int RemoveKeSP(string make);
        public int UpdateKeSP(KeSPModel model);
    }
    public class KeSPRepository : IKeSPRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<KeSPModel> getAllKeSP()
        {
            string query = "SELECT * FROM KE";
            DataTable tbl = con.getDataTable(query);
            List<KeSPModel> lst = new List<KeSPModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                KeSPModel kh = new KeSPModel(
                    tbl.Rows[i][0].ToString(), //make
                      tbl.Rows[i][1].ToString(),//tenke
                      tbl.Rows[i][2].ToString(),//Soluongsp
                      tbl.Rows[i][3].ToString(), //makeu
                      tbl.Rows[i][4].ToString() //masp
                                                );
                lst.Add(kh);
            }
            return lst;
        }
        public KeSPModel getKeSPById(string make)
        {
            string query = "SELECT * FROM KE where MAKE ='" + make + "'";
            DataTable tbl = con.getDataTable(query);

            KeSPModel kh = new KeSPModel(
                      tbl.Rows[0][0].ToString(), //make
                      tbl.Rows[0][1].ToString(),//tenke
                      tbl.Rows[0][2].ToString(),//Soluongsp
                      tbl.Rows[0][3].ToString(), //makeu
                      tbl.Rows[0][4].ToString() //masp
                                                 );
            return kh;
        }
        public int AddKeSP(KeSPModel model)
        {
            try
            {
                string query = "insert into KE(MAKE,TENKE,SOLUONGSP,MAKHU,MASP) values ('" + model.MA_KE + "',N'" + model.TEN_KE + "','" + model.SOLUONGSP + "',N'" + model.MAKHU + "','" + model.MASP + "')";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemoveKeSP(string make)
        {
            try
            {
                string query = "delete from KE where MAKE ='" + make + "'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdateKeSP(KeSPModel model)
        {
            try
            {
                RemoveKeSP(model.MA_KE);
                AddKeSP(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
