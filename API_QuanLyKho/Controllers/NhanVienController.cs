﻿using API_QuanLyKho.Hepper;
using API_QuanLyKho.Model;
using API_QuanLyKho.Service;
using Microsoft.AspNetCore.Mvc;

namespace API_QuanLyKhoHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly INhanVienService NhanVienService;
        public NhanVienController(INhanVienService NhanVienService)
        {
            this.NhanVienService = NhanVienService;
        }
        [Route(WebEndpoint.NhanVien.GET_ALL)]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<NhanVienModel> lst = NhanVienService.getAllNhanVien();
            if (lst == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsNhanVien.NOT_FOUND_NhanVien); }
            return Ok(lst);
        }
        [Route(WebEndpoint.NhanVien.GET_BY_ID)]
        [HttpGet]
        public IActionResult GetID()
        {
            string maph = RouteData.Values["manhanvien"].ToString();
            if (String.IsNullOrEmpty(maph)) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            NhanVienModel model = NhanVienService.getNhanVienById(maph);
            if (model == null) { return BadRequest(ApplicationContants.ReponseMessageConstantsNhanVien.NOT_FOUND_NhanVien); }
            return Ok(model);
        }
        [Route(WebEndpoint.NhanVien.ADD_ITEM)]
        [HttpPost]
        public IActionResult AddPhieuNh(NhanVienModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = NhanVienService.AddNhanVien(model);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsNhanVien.EXISTED_NhanVien); }
            return Ok(ApplicationContants.ReponseMessageConstantsNhanVien.UPDATE_NhanVien_SUCCESS);

        }
        [Route(WebEndpoint.NhanVien.REMOVE_BY_NHANVIEN)]
        [HttpDelete]
        public IActionResult RemovePhieuNh()
        {
            string maph = RouteData.Values["manhanvien"].ToString();
            if (String.IsNullOrEmpty(maph))
            {
                return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED);
            }
            int kq = NhanVienService.RemoveNhanVien(maph);
            if (kq == 0) { return BadRequest(ApplicationContants.ReponseMessageConstantsNhanVien.NOT_FOUND_NhanVien); }
            return Ok(ApplicationContants.ReponseMessageConstantsNhanVien.DELETE_NhanVien_SUCCESS);
        }
        [Route(WebEndpoint.NhanVien.UPDATE_ITEM)]
        [HttpPut]
        public IActionResult UpdatePhieuXuatHang(NhanVienModel model)
        {
            if (model == null) { return BadRequest(ApplicationContants.ResponseCodeConstants.FAILED); }
            int kq = NhanVienService.UpdateNhanVien(model);
            if (kq == 1) { return Ok(ApplicationContants.ReponseMessageConstantsNhanVien.UPDATE_NhanVien_SUCCESS); }
            return BadRequest(ApplicationContants.ReponseMessageConstantsNhanVien.NOT_FOUND_NhanVien);
        }
    }
}