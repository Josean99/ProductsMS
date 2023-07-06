﻿using AutoMapper;
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
    public class TextsWriteService : ITextsWriteService
    {
        private readonly IBaseWriteRepository<Text> _baseWriteRepository;
        private readonly IBaseReadRepository _baseReadRepository;
        private readonly IMapper _mapper;
        public TextsWriteService(
                                IBaseWriteRepository<Text> baseWriteRepository,
                                IBaseReadRepository baseReadRepository,
                                IMapper mapper)
        {
            _baseWriteRepository = baseWriteRepository;
            _baseReadRepository = baseReadRepository;
            _mapper = mapper;
        }

        public async Task<Result<TextRequestDTO>> Create(TextRequestDTO dto)
        {
            Text entity = _mapper.Map<TextRequestDTO, Text>(dto);
            await _baseWriteRepository.Create(entity);
            await _baseWriteRepository.Save();
            return new Result<TextRequestDTO>().Ok(dto);
        }

        public async Task<Result<TextRequestDTO>> Update(TextRequestDTO dto)
        {
            Text entity = _mapper.Map<TextRequestDTO, Text>(dto);
            entity.FechaBaja = DateTime.Now;
            await _baseWriteRepository.Update(entity);
            await _baseWriteRepository.Save();
            return new Result<TextRequestDTO>().Ok(dto);
        }

        public async Task<Result<Guid>> SoftDelete(Guid id)
        {
            Text entity = await _baseReadRepository.GetFirstByCondition<Text>(p => p.Id == id);
            entity.FechaBaja = DateTime.Now;
            await _baseWriteRepository.Update(entity);
            await _baseWriteRepository.Save();
            return new Result<Guid>().Ok(id);
        }

        public async Task<Result<TextRequestDTO>> Delete(TextRequestDTO dto)
        {
            Text entity = _mapper.Map<TextRequestDTO, Text>(dto);
            await _baseWriteRepository.Delete(entity);
            await _baseWriteRepository.Save();
            return new Result<TextRequestDTO>().Ok(dto);
        }

    }
}