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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
           return Ok(_colorService.GetAll());
        }

        [HttpGet("getbyid")]
        public IActionResult getbyid(int id)
        {
            return Ok(_colorService.GetColordById(id));
        }
        [HttpPost("add")]
        public IActionResult Post(Color color)
        {
            _colorService.Add(color);
            return Ok(color);
        }
        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            _colorService.Update(color);
            return Ok(color);
        }
        public IActionResult Delete(Color color)
        {
            _colorService.Delete(color);
            return Ok();
        }
    }
}
