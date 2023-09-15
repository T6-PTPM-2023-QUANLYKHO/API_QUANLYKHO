using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using AutoMapper.Configuration.Conventions;
using System.Collections.Generic;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface IPhieuXuatHangRepository
    {
        public List<PhieuXuatHangModel> getAllPhieuXuatHang();
        public PhieuXuatHangModel getPhieuXuatHangById(string maPhieu);
        public int AddPhieuXuatHang(PhieuXuatHangModel model);
        public int RemovePhieuXuatHang(string maphieuxuat);
        public int UpdatePhieuXuatHang(PhieuXuatHangModel model);
    }
    public class PhieuXuatHangRepository:IPhieuXuatHangRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<PhieuXuatHangModel> getAllPhieuXuatHang()
        {
            List<PhieuXuatHangModel> lst = new List<PhieuXuatHangModel> ();
            string query = "select * from PHIEU_XUAT_HANG";
            DataTable tbl = con.getDataTable(query);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                PhieuXuatHangModel item = new PhieuXuatHangModel(
                    tbl.Rows[i][0].ToString(),//MAPH_XH
                    tbl.Rows[i][1].ToString(),//NGAY_XH
                    tbl.Rows[i][3].ToString(),//MAKH
                    tbl.Rows[i][2].ToString(),//TONGTIEN_XH
                    tbl.Rows[i][4].ToString());//MANV
                lst.Add(item);
            }
            return lst;
        }
        public PhieuXuatHangModel getPhieuXuatHangById(string maPhieu)
        {
            string query = "select * from PHIEU_XUAT_HANG where MAPH_XH = '" + maPhieu + "'";
            DataTable tbl = con.getDataTable(query);

            PhieuXuatHangModel item = new PhieuXuatHangModel(
                tbl.Rows[0].ToString(),//MAPH_XH
                tbl.Rows[1].ToString(),//NGAY_XH
                tbl.Rows[3].ToString(),//MAKH
                tbl.Rows[2].ToString(),//TONGTIEN_XH
                tbl.Rows[4].ToString());//MANV
            return item;
        }
        public int AddPhieuXuatHang(PhieuXuatHangModel model)
        {
            try
            {
                string query = "insert into PHIEU_XUAT_HANG(MAPH_XH,NGAY_XH,MAKH,MANV) values ('" + model.MAPH_XH + "','" + model.NGAY_XH + "','" + model.MAKH + "','" + model.MANV + "')";

                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }    
        public int RemovePhieuXuatHang(string maphieuxuat)
        {
            try
            {
                string query = "delete from PHIEU_XUAT_HANG where MAPH_XH = '"+maphieuxuat+"'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdatePhieuXuatHang(PhieuXuatHangModel model)
        {
            try
            {
                RemovePhieuXuatHang(model.MAPH_XH);
                AddPhieuXuatHang(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
