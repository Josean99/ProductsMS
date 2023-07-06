using DTOs.RequestDTOs;
using DTOs.ResponseDTOs;
using EntityService.Model;
using Infrastructure.WebApiServices.Results;
using IReadBusinessLayer.Base;

namespace IWriteBusinessLayer
{
    public interface IBrandsWriteService
    {
        Task<Result<BrandRequestDTO>> Create(BrandRequestDTO dto);
        Task<Result<BrandRequestDTO>> Update(BrandRequestDTO dto);
        Task<Result<Guid>> SoftDelete(Guid id);
        Task<Result<BrandRequestDTO>> Delete(BrandRequestDTO dto);
    }
}