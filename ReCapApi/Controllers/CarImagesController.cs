using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCapApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_carImageService.GetById(id));
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result=_carImageService.Add(carImage, file);
            if (result.Success)
                return Ok(carImage);
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var carImages = _carImageService.GetById(Id).Data;
            var result = _carImageService.Update(carImages, file);
            return Ok(carImages);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            _carImageService.Delete(carImage);
            return Ok();
        }

    }
}
