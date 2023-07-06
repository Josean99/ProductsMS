using AutoMapper;
using EntityService.Model;
using IWriteBusinessLayer;
using IReadRepositories;
using IWriteRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using IWriteRepository.Base;
using IReadRepositories.Base;
using ReadRepositories.Base;
using DTOs.RequestDTOs;
using Infrastructure.WebApiServices.Results;

namespace WriteBusinessLayer
{
    public class BrandsWriteService : IBrandsWriteService
    {
        private readonly IBaseWriteRepository<Brand> _baseWriteRepository;
        private readonly IBaseReadRepository _baseReadRepository;
        private readonly IMapper _mapper;
        public BrandsWriteService(
                                IBaseWriteRepository<Brand> baseWriteRepository,
                                IBaseReadRepository baseReadRepository,
                                IMapper mapper)
        {
            _baseWriteRepository = baseWriteRepository;
            _baseReadRepository = baseReadRepository;
            _mapper = mapper;
        }

        public async Task<Result<BrandRequestDTO>> Create(BrandRequestDTO dto) 
        {
            Brand entity = _mapper.Map<BrandRequestDTO, Brand>(dto);
            await _baseWriteRepository.Create(entity);
            await _baseWriteRepository.Save();
            return new Result<BrandRequestDTO>().Ok(dto);
        }

        public async Task<Result<BrandRequestDTO>> Update(BrandRequestDTO dto)
        {
            Brand entity = _mapper.Map<BrandRequestDTO, Brand>(dto);
            entity.FechaBaja = DateTime.Now;
            await _baseWriteRepository.Update(entity);
            await _baseWriteRepository.Save();
            return new Result<BrandRequestDTO>().Ok(dto);
        }

        public async Task<Result<Guid>> SoftDelete(Guid id)
        {
            Brand entity = await _baseReadRepository.GetFirstByCondition<Brand>(p => p.Id == id);
            entity.FechaBaja = DateTime.Now;
            await _baseWriteRepository.Update(entity);
            await _baseWriteRepository.Save();
            return new Result<Guid>().Ok(id);
        }

        public async Task<Result<BrandRequestDTO>> Delete(BrandRequestDTO dto)
        {
            Brand entity = _mapper.Map<BrandRequestDTO, Brand>(dto);
            await _baseWriteRepository.Delete(entity);
            await _baseWriteRepository.Save();
            return new Result<BrandRequestDTO>().Ok(dto);
        }
    }
}