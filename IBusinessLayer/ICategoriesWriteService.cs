﻿using DTOs.RequestDTOs;
using EntityService.Model;
using Infrastructure.WebApiServices.Results;

namespace IWriteBusinessLayer
{
    public interface ICategoriesWriteService
    {
        Task<Result<CategoryRequestDTO>> Create(CategoryRequestDTO dto);
        Task<Result<CategoryRequestDTO>> Update(CategoryRequestDTO dto);
        Task<Result<Guid>> SoftDelete(Guid id);
        Task<Result<CategoryRequestDTO>> Delete(CategoryRequestDTO dto);
    }
}