﻿using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using System.Data;

namespace API_QuanLyKho.Repository
{
    public interface INhomNguoiDungRepository
    {
        public List<NhomNguoiDungModel> getAllNhomNguoiDung();
        public NhomNguoiDungModel getNhomNguoiDungById(string manhom);
        public int AddNhomNguoiDung(NhomNguoiDungModel model);
        public int RemoveNhomNguoiDung(string manhom);
        public int UpdateNhomNguoiDung(NhomNguoiDungModel model);
    }
    public class NhomNguoiDungRepository : INhomNguoiDungRepository
    {
        MyLibConnectDB con = new MyLibConnectDB();
        public List<NhomNguoiDungModel> getAllNhomNguoiDung()
        {
            string query = "SELECT * FROM QL_NHOMNGUOIDUNG";
            DataTable tbl = con.getDataTable(query);
            List<NhomNguoiDungModel> lst = new List<NhomNguoiDungModel>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                NhomNguoiDungModel kh = new NhomNguoiDungModel(
                    tbl.Rows[i][0].ToString(), //manhom
                      tbl.Rows[i][1].ToString(),//tennhom
                      tbl.Rows[i][2].ToString()//ghichu
                                                );
                lst.Add(kh);
            }
            return lst;
        }
        public NhomNguoiDungModel getNhomNguoiDungById(string manhom)
        {
            string query = "SELECT * FROM QL_NHOMNGUOIDUNG where MANHOM ='" + manhom + "'";
            DataTable tbl = con.getDataTable(query);

            NhomNguoiDungModel kh = new NhomNguoiDungModel(
                      tbl.Rows[0][0].ToString(), //manhom
                      tbl.Rows[0][1].ToString(),//tennhom
                      tbl.Rows[0][2].ToString()//ghichu
                                                 );
            return kh;
        }
        public int AddNhomNguoiDung(NhomNguoiDungModel model)
        {
            try
            {
                string query = "insert into QL_NHOMNGUOIDUNG(MANHOM,TENNHOM,GHICHU) values ('" + model.MA_NHOM + "','" + model.TEN_NHOM + "','" + model.GHI_CHU + "')";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int RemoveNhomNguoiDung(string manhom)
        {
            try
            {
                string query = "delete from QL_NHOMNGUOIDUNG where MANHOM ='" + manhom + "'";
                con.updateToDatabase(query);
                return 1;
            }
            catch { return 0; }
        }
        public int UpdateNhomNguoiDung(NhomNguoiDungModel model)
        {
            try
            {
                RemoveNhomNguoiDung(model.MA_NHOM);
                AddNhomNguoiDung(model);
                return 1;
            }
            catch { return 0; }
        }
    }
}
