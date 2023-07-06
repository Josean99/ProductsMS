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
    public class CategoriesWriteService : ICategoriesWriteService
    {
        private readonly IBaseWriteRepository<Category> _baseWriteRepository;
        private readonly ICategoriesReadRepository _baseReadRepository;
        private readonly IMapper _mapper;
        public CategoriesWriteService(
                                IBaseWriteRepository<Category> baseWriteRepository,
                                ICategoriesReadRepository baseReadRepository,
                                IMapper mapper)
        {
            _baseWriteRepository = baseWriteRepository;
            _baseReadRepository = baseReadRepository;
            _mapper = mapper;
        }

        public async Task<Result<CategoryRequestDTO>> Create(CategoryRequestDTO dto)
        {
            Category entity = _mapper.Map<CategoryRequestDTO, Category>(dto);
            await _baseWriteRepository.Create(entity);
            await _baseWriteRepository.Save();
            return new Result<CategoryRequestDTO>().Ok(dto);
        }

        public async Task<Result<CategoryRequestDTO>> Update(CategoryRequestDTO dto)
        {
            Category entity = _mapper.Map<CategoryRequestDTO, Category>(dto);
            entity.FechaBaja = DateTime.Now;
            await _baseWriteRepository.Update(entity);
            await _baseWriteRepository.Save();
            return new Result<CategoryRequestDTO>().Ok(dto);
        }

        public async Task<Result<Guid>> SoftDelete(Guid id)
        {
            Category entity = await _baseReadRepository.GetFirstByCondition<Category>(p => p.Id == id);
            entity.FechaBaja = DateTime.Now;
            await _baseWriteRepository.Update(entity);
            await _baseWriteRepository.Save();
            return new Result<Guid>().Ok(id);
        }

        public async Task<Result<CategoryRequestDTO>> Delete(CategoryRequestDTO dto)
        {
            Category entity = _mapper.Map<CategoryRequestDTO, Category>(dto);
            await _baseWriteRepository.Delete(entity);
            await _baseWriteRepository.Save();
            return new Result<CategoryRequestDTO>().Ok(dto);
        }

    }
}