using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityService.Model;
using IWriteBusinessLayer;
using AutoMapper;
using IReadBusinessLayer.Base;
using DTOs.RequestDTOs;

namespace ProductsWriteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImagesWriteService _imagesWriteService;

        public ImagesController(IImagesWriteService imagesWriteService)
        {
            _imagesWriteService = imagesWriteService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ImageRequestDTO imageDTO)
        {
            var result = await _imagesWriteService.Create(imageDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ImageRequestDTO imageDTO)
        {
            var result = await _imagesWriteService.Update(imageDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut("SoftDelete")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            var result = await _imagesWriteService.SoftDelete(id);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }
    }
}
