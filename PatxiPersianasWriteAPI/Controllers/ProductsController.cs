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
    public class ProductsController : ControllerBase
    {
        private readonly IProductsWriteService _productsWriteService;

        public ProductsController(IProductsWriteService productsWriteService)
        {
            _productsWriteService = productsWriteService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRequestDTO productDto)
        {
            var result = await _productsWriteService.Create(productDto);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPost("CreateProductWithImages")]
        public async Task<IActionResult> CreateProductWithImages(ProductWithImagesRequestDTO productDto)
        {
            var result = await _productsWriteService.CreateProductWithImages(productDto);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductRequestDTO productDto)
        {
            var result = await _productsWriteService.Update(productDto);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut("UpdateProductWithImages")]
        public async Task<IActionResult> UpdateProductWithImages(ProductWithImagesRequestDTO productWithImagesDTO)
        {
            var result = await _productsWriteService.UpdateProductWithImages(productWithImagesDTO);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut("SoftDelete")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            var result = await _productsWriteService.SoftDelete(id);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

        [HttpPut("SoftDeleteWithImages")]
        public async Task<IActionResult> SoftDeleteWithImages(Guid id)
        {
            var result = await _productsWriteService.SoftDeleteWithImages(id);
            return result is not null ? Ok() : (IActionResult)NoContent();
        }

    }
}
