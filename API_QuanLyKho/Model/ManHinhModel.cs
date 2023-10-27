namespace API_QuanLyKho.Model
{
    public class ManHinhModel
    {
        public ManHinhModel(string MA_NHOM, string TEN_NHOM)
        {
            this.MA_NHOM = MA_NHOM;
            this.TEN_NHOM = TEN_NHOM;
           
        }
        public string MA_NHOM { get; set; }
        public string TEN_NHOM { get; set; }
     

    }
}

