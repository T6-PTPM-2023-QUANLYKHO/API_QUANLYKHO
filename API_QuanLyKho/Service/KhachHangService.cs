using API_QuanLyKho.Model;
using API_QuanLyKho.Repository;

namespace API_QuanLyKho.Service
{
    public interface IKhachHangService
    {
        public List<KhachHangModel> getAllKhachHang();
        public KhachHangModel getKhachHangById(string makh);
        public int AddKhachHang(KhachHangModel model);
        public int RemovekhachHang(string makh);
        public int UpdatekhachHang(KhachHangModel model);
    }
    public class KhachHangService:IKhachHangService
    {
        private readonly IKhachHangRepository khachHangRepository;
        public KhachHangService(IKhachHangRepository khachHangRepository) { this.khachHangRepository = khachHangRepository; }
        public List<KhachHangModel> getAllKhachHang()
        {
            List<KhachHangModel> lst = new List<KhachHangModel>();
            lst = khachHangRepository.getAllKhachHang();
            return lst;
        }
        public KhachHangModel getKhachHangById(string makh)
        {
            if (String.IsNullOrEmpty(makh))
            {
                return null;
            }
            return khachHangRepository.getKhachHangById(makh);
        }
        public int AddKhachHang(KhachHangModel model)
        {
            if (model == null) return 0;
            return khachHangRepository.AddKhachHang(model);
        }
        public int RemovekhachHang(string makh)
        {
            if (String.IsNullOrEmpty(makh)) return 0;
            return khachHangRepository.RemoveKhachHang(makh);
        }
        public int UpdatekhachHang(KhachHangModel model)
        {
            if (model == null) return 0;
            return khachHangRepository.UpdateKhachHang(model);
        }
    }
}
