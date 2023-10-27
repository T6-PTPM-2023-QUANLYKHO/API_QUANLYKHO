using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IManHinhRepository
    {
        public List<ManHinhModel> getAllManHinh();
        public ManHinhModel getManHinhById(string mamanhinh);
        public int AddManHinh(ManHinhModel model);
        public int RemoveManHinh(string mamanhinh);
        public int UpdateManHinh(ManHinhModel model);
    }
    public class ManHinhRepository : IManHinhRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<ManHinhModel> getAllManHinh()
        {
            string query = "SELECT * FROM DM_MANHINH";
            DataTable tbl = con.getDataTable(query);
            List<ManHinhModel> lst = new List<ManHinhModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ManHinhModel kh = new ManHinhModel(
                    tbl.Rows[i][0].ToString(), //mamanhinh
                      tbl.Rows[i][1].ToString()//tenmanhinh
                                                );
                lst.Add(kh);
            }
            return lst;
        }
        public ManHinhModel getManHinhById(string mamanhinh)
        {
            string query = "SELECT * FROM DM_MANHINH where MAMANHINH ='" + mamanhinh + "'";
            DataTable tbl = con.getDataTable(query);

            ManHinhModel kh = new ManHinhModel(
                      tbl.Rows[0][0].ToString(), //mamanhinh
                      tbl.Rows[0][1].ToString()//tenmanhinh
                                                 );
            return kh;
        }
        public int AddManHinh(ManHinhModel model)
        {
            try
            {
                string query = "insert into DM_MANHINH(MAMANHINH,TENMANHINH) values ('" + model.MA_NHOM + "','" + model.TEN_NHOM  + "')";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemoveManHinh(string mamanhinh)
        {
            try
            {
                string query = "delete from DM_MANHINH where MAMANHINH ='" + mamanhinh + "'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdateManHinh(ManHinhModel model)
        {
            try
            {
                RemoveManHinh(model.MA_NHOM);
                AddManHinh(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
