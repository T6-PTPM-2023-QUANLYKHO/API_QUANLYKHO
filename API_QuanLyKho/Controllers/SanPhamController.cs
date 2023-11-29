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
        [Route(WebEndpoint.SanPham.GET_BY_NCC)]
        [HttpGet]
        public IActionResult GetNCC()
        {
            string ma_ncc = RouteData.Values["mancc"].ToString();
            if (String.IsNullOrEmpty(ma_ncc)) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            List<SanPhamModel> model = sanPhamService.getSanPhamByNCC(ma_ncc);
            if (model == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsSanPham.NOT_FOUND_SanPham); }
            return Ok(model);
        }
        [Route(WebEndpoint.SanPham.GET_BY_KHO)]
        [HttpGet]
        public IActionResult GetKho()
        {
            string ma_kho = RouteData.Values["makho"].ToString();
            if (String.IsNullOrEmpty(ma_kho)) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            List<SanPhamModel> model = sanPhamService.getSanPhamByKho(ma_kho);
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
        

    }
}

