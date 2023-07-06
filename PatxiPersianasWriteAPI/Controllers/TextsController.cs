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
    public class TextsController : ControllerBase
    {
        private readonly ITextsWriteService _textWriteService;

        public TextsController(ITextsWriteService textWriteService)
        {
            _textWriteService = textWriteService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(TextRequestDTO textDTO)
        {
            var result = await _textWriteService.Create(textDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(TextRequestDTO textDTO)
        {
            var result = await _textWriteService.Update(textDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut("SoftDelete")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            var result = await _textWriteService.SoftDelete(id);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }
    }
}
