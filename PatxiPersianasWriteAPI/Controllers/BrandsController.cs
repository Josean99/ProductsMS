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
using Infrastructure.WebApiServices.Results;

namespace ProductsWriteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsWriteService _brandWriteService;

        public BrandsController(IBrandsWriteService brandWriteService)
        {
            _brandWriteService = brandWriteService;
        }

        [HttpPost]
        public async Task<Result<BrandRequestDTO>> Create(BrandRequestDTO brandDTO)
        {
            var result = await _brandWriteService.Create(brandDTO);
            return result;
        }

        [HttpPut]
        public async Task<Result<BrandRequestDTO>> Update(BrandRequestDTO brandDTO)
        {
            var result = await _brandWriteService.Update(brandDTO);
            return result;
        }

        [HttpPut("SoftDelete")]
        public async Task<Result<Guid>> SoftDelete(Guid id)
        {
            var result = await _brandWriteService.SoftDelete(id);
            return result;
        }
    }
}
