﻿using API_QuanLyKho.Model;
using API_QuanLyKho.Repository;

namespace API_QuanLyKho.Service
{
    public interface IChiTietNHService
    {
        public List<ChiTietNHModel> getAllChiTietNH();
        public ChiTietNHModel getChiTietNHById(string maCTNH);
        public int AddChiTietNH(ChiTietNHModel modelCTNH);
        public int RemoveChiTietNH(string maCTNH);
        public int UpdateChiTietNH(ChiTietNHModel modelCTNH);
    }
    public class ChiTietNHService: IChiTietNHService
    {
        private readonly IChiTietNHRepository chiTietNHRepository;
        public ChiTietNHService(IChiTietNHRepository chiTietNHRepository) { this.chiTietNHRepository = chiTietNHRepository; }
        public List<ChiTietNHModel> getAllChiTietNH()
        {
            List<ChiTietNHModel> lst = new List<ChiTietNHModel>();
            lst = chiTietNHRepository.getAllChiTietNH();
            return lst;
        }
        public ChiTietNHModel getChiTietNHById(string maCTNH)
        {
            if (String.IsNullOrEmpty(maCTNH))
            {
                return null;
            }
            return chiTietNHRepository.getChiTietNHById(maCTNH);
        }
        public int AddChiTietNH(ChiTietNHModel model)
        {
            if (model == null) return 0;
            return chiTietNHRepository.AddChiTietNH(model);
        }
        public int RemoveChiTietNH(string maCTNH)
        {
            if (String.IsNullOrEmpty(maCTNH)) return 0;
            return chiTietNHRepository.RemoveChiTietNH(maCTNH);
        }
        public int UpdateChiTietNH(ChiTietNHModel model)
        {
            if (model == null) return 0;
            return chiTietNHRepository.UpdateChiTietNH(model);
        }
    }
}
