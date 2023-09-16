using API_QuanLyKho.Model;
using API_QuanLyKho.Repository;

namespace API_QuanLyKho.Service
{
    public interface ISanPhamService
    {
        public List<SanPhamModel> getAllSanPham();
        public SanPhamModel getSanPhamById(string masp);
        public int AddSanPham(SanPhamModel model);
        public int RemoveSanPham(string masp);
        public int UpdateSanPham(SanPhamModel model);
    }
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanPhamRepository SanPhamRepository;
        public SanPhamService(ISanPhamRepository SanPhamRepository) { this.SanPhamRepository = SanPhamRepository; }
        public List<SanPhamModel> getAllSanPham()
        {
            List<SanPhamModel> lst = new List<SanPhamModel>();
            lst = SanPhamRepository.getAllSanPham();
            return lst;
        }
        public SanPhamModel getSanPhamById(string masp)
        {
            if (String.IsNullOrEmpty(masp))
            {
                return null;
            }
            return SanPhamRepository.getSanPhamById(masp);
        }
        public int AddSanPham(SanPhamModel model)
        {
            if (model == null) return 0;
            return SanPhamRepository.AddSanPham(model);
        }
        public int RemoveSanPham(string masp)
        {
            if (String.IsNullOrEmpty(masp)) return 0;
            return SanPhamRepository.RemoveSanPham(masp);
        }
        public int UpdateSanPham(SanPhamModel model)
        {
            if (model == null) return 0;
            return SanPhamRepository.UpdateSanPham(model);
        }
    }
}
