namespace API_QuanLyKho.Model
{
    public class PhanQuyenModel
    {
        public PhanQuyenModel(string MA_NHOM_NGUOI_DUNG, string MA_MAN_HINH, string COQUYEN)
        {
            this.MA_NHOM_NGUOI_DUNG = MA_NHOM_NGUOI_DUNG;
            this.MA_MAN_HINH = MA_MAN_HINH;
            this.COQUYEN = MA_NHOM_NGUOI_DUNG;
         
        }
        public string MA_NHOM_NGUOI_DUNG { get; set; }
        public string MA_MAN_HINH { get; set; }
        public string COQUYEN { get; set; }
      
    }
}
