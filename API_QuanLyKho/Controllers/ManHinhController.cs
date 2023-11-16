using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using API_QuanLyKho.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_QuanLyKho.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManHinhController : ControllerBase
    {
        private readonly IManHinhService mhomNguoiDungService;
        public ManHinhController(IManHinhService mhomNguoiDungService)
        {
            this.mhomNguoiDungService = mhomNguoiDungService;
        }
        [Route(WebEndpoint.ManHinh.GET_ALL)]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ManHinhModel> lst = mhomNguoiDungService.getAllManHinh();
            if (lst == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsManHinh.NOT_FOUND_MaManHinh); }
            return Ok(lst);
        }
        [Route(WebEndpoint.ManHinh.GET_BY_ID)]
        [HttpGet]
        public IActionResult GetID()
        {
            string mand = RouteData.Values["id"].ToString();
            if (String.IsNullOrEmpty(mand)) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            ManHinhModel model = mhomNguoiDungService.getManHinhById(mand);
            if (model == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsManHinh.NOT_FOUND_MaManHinh); }
            return Ok(model);
        }
        [Route(WebEndpoint.ManHinh.ADD_ITEM)]
        [HttpPost]
        public IActionResult Addnd(ManHinhModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = mhomNguoiDungService.AddManHinh(model);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsManHinh.EXISTED_MaManHinh); }
            return Ok(ApplicationContants.ReponseMessageConstantsManHinh.UPDATE_MaManHinh_SUCCESS);

        }
        [Route(WebEndpoint.ManHinh.REMOVE_BY_MaManHinh)]
        [HttpDelete]
        public IActionResult Removend()
        {
            string mand = RouteData.Values["id"].ToString();
            if (String.IsNullOrEmpty(mand))
            {
                return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED);
            }
            int kq = mhomNguoiDungService.Removemh(mand);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsManHinh.NOT_FOUND_MaManHinh); }
            return Ok(ApplicationContants.ReponseMessageConstantsManHinh.DELETE_MaManHinh_SUCCESS);
        }
        [Route(WebEndpoint.ManHinh.UPDATE_ITEM)]
        [HttpPut]
        public IActionResult UpdateManHinh(ManHinhModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = mhomNguoiDungService.Updatemh(model);
            if (kq == 1) { return Ok(ApplicationContants.ReponseMessageConstantsManHinh.UPDATE_MaManHinh_SUCCESS); }
            return BadRequest(ApplicationContants.ReponseMessageConstantsManHinh.NOT_FOUND_MaManHinh);
        }
    }
}
