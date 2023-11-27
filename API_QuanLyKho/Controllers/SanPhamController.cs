using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using API_QuanLyKho.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_QuanLyKho.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamService sanPhamService;
        public SanPhamController(ISanPhamService sanPhamService)
        {
            this.sanPhamService = sanPhamService;
        }
        [Route(WebEndpoint.SanPham.GET_ALL)]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<SanPhamModel> lst = sanPhamService.getAllSanPham();
            if (lst == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsSanPham.NOT_FOUND_SanPham); }
            return Ok(lst);
        }
        [Route(WebEndpoint.SanPham.GET_BY_ID)]
        [HttpGet]
        public IActionResult GetID()
        {
            string masp = RouteData.Values["id"].ToString();
            if (String.IsNullOrEmpty(masp)) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            SanPhamModel model = sanPhamService.getSanPhamById(masp);
            if (model == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsSanPham.NOT_FOUND_SanPham); }
            return Ok(model);
        }
        [Route(WebEndpoint.SanPham.ADD_ITEM)]
        [HttpPost]
        public IActionResult AddSanPham(SanPhamModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = sanPhamService.AddSanPham(model);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsSanPham.EXISTED_SanPham); }
            return Ok(ApplicationContants.ReponseMessageConstantsSanPham.UPDATE_SanPham_SUCCESS);

        }
        [Route(WebEndpoint.SanPham.REMOVE_BY_MASP)]
        [HttpDelete]
        public IActionResult RemoveSanPham()
        {
            string masp = RouteData.Values["id"].ToString();
            if (String.IsNullOrEmpty(masp))
            {
                return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED);
            }
            int kq = sanPhamService.RemoveSanPham(masp);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsSanPham.NOT_FOUND_SanPham); }
            return Ok(ApplicationContants.ReponseMessageConstantsSanPham.DELETE_SanPham_SUCCESS);
        }
        [Route(WebEndpoint.SanPham.UPDATE_ITEM)]
        [HttpPut]
        public IActionResult UpdateSanPham(SanPhamModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = sanPhamService.UpdateSanPham(model);
            if (kq == 1) { return Ok(ApplicationContants.ReponseMessageConstantsSanPham.UPDATE_SanPham_SUCCESS); }
            return BadRequest(ApplicationContants.ReponseMessageConstantsSanPham.NOT_FOUND_SanPham);
        }
        [HttpGet("getimage")]
        public IActionResult GetImage()
        {
            // Đường dẫn tương đối đến thư mục chứa hình ảnh trong wwwroot
            //var imagePath = "~/uploads/tintuc/2022/11/12/sinh-vien.jpeg";
            var imagePath = "~/img/sinh-vien.jpg";

            // Tạo đường dẫn đầy đủ bằng cách sử dụng Url.Content
            var imageUrl = Url.Content(imagePath);

            return Ok(new { ImageUrl = imageUrl });
        }


    }
}

