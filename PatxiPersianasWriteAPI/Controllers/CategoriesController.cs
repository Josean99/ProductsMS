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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesWriteService _categoriesWriteService;

        public CategoriesController(ICategoriesWriteService categoriesWriteService)
        {
            _categoriesWriteService = categoriesWriteService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryRequestDTO categoryDTO)
        {
            var result = await _categoriesWriteService.Create(categoryDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryRequestDTO categoryDTO)
        {
            var result = await _categoriesWriteService.Update(categoryDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut("SoftDelete")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            var result = await _categoriesWriteService.SoftDelete(id);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }
    }
}
