using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using API_QuanLyKho.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_QuanLyKho.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangNhapController : ControllerBase
    {
        private readonly IDangNhapService DangNhapService;
        public DangNhapController(IDangNhapService DangNhapService)
        {
            this.DangNhapService = DangNhapService;
        }
        [Route(WebEndpoint.DangNhap.GET_ALL)]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<DangNhapModel> lst = DangNhapService.getAllDangNhap();
            if (lst == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsDangNhap.NOT_FOUND_TaiKhoanDN); }
            return Ok(lst);
        }
        [Route(WebEndpoint.DangNhap.GET_BY_ID)]
        [HttpGet]
        public IActionResult GetID()
        {
            string mand = RouteData.Values["id"].ToString();
            if (String.IsNullOrEmpty(mand)) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            DangNhapModel model = DangNhapService.getDangNhapById(mand);
            if (model == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsDangNhap.NOT_FOUND_TaiKhoanDN); }
            return Ok(model);
        }
        [Route(WebEndpoint.DangNhap.ADD_ITEM)]
        [HttpPost]
        public IActionResult Addnd(DangNhapModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = DangNhapService.AddDangNhap(model);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsDangNhap.EXISTED_TaiKhoanDN); }
            return Ok(ApplicationContants.ReponseMessageConstantsDangNhap.UPDATE_TaiKhoanDN_SUCCESS);

        }
        [Route(WebEndpoint.DangNhap.REMOVE_BY_TaiKhoanDN)]
        [HttpDelete]
        public IActionResult Removend()
        {
            string mand = RouteData.Values["id"].ToString();
            if (String.IsNullOrEmpty(mand))
            {
                return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED);
            }
            int kq = DangNhapService.Removedn(mand);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsDangNhap.NOT_FOUND_TaiKhoanDN); }
            return Ok(ApplicationContants.ReponseMessageConstantsDangNhap.DELETE_TaiKhoanDN_SUCCESS);
        }
        [Route(WebEndpoint.DangNhap.UPDATE_ITEM)]
        [HttpPut]
        public IActionResult UpdateDangNhap(DangNhapModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = DangNhapService.Updatedn(model);
            if (kq == 1) { return Ok(ApplicationContants.ReponseMessageConstantsDangNhap.UPDATE_TaiKhoanDN_SUCCESS); }
            return BadRequest(ApplicationContants.ReponseMessageConstantsDangNhap.NOT_FOUND_TaiKhoanDN);
        }
    }
}
