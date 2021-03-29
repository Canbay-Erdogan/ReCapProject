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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Post(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult Get(int id)
        {
            return Ok(_brandService.GetBrandById(id));
        }

        [HttpPut]
        public IActionResult Put(Brand brand)
        {
            var result = _brandService.Update(brand);
            return Ok(result.Message);
        }

        [HttpDelete]
        public IActionResult Delete(Brand brand)
        {
           var result = _brandService.Delete(brand);
            return Ok(result.Message);
        }

    }
}
