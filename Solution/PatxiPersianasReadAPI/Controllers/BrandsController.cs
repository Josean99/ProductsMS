
using Microsoft.AspNetCore.Mvc;
using IReadBusinessLayer;

namespace ProductsReadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsReadService _brandReadService;

        public BrandsController(IBrandsReadService brandReadService)
        {
            _brandReadService = brandReadService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var resultado = await _brandReadService.GetAll();
            return resultado is not null ? Ok(resultado) : (IActionResult)NoContent();
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var resultado = await _brandReadService.Get(id);
            return resultado is not null ? Ok(resultado) : (IActionResult)NoContent();
        }

        [HttpGet]
        [Route("GetIncluded")]
        public async Task<IActionResult> GetIncluded()
        {
            var resultado = await _brandReadService.GetAll();
            return resultado is not null ? Ok(resultado) : (IActionResult)NoContent();
        }


        [HttpGet]
        [Route("GetIncluded/{id}")]
        public async Task<IActionResult> GetIncluded(Guid id)
        {
            var resultado = await _brandReadService.Get(id);
            return resultado is not null ? Ok(resultado) : (IActionResult)NoContent();
        }



    }
}
