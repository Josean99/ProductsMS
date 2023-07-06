using DTOs.RequestDTOs;
using EntityService.Model;
using Infrastructure.WebApiServices.Results;

namespace IWriteBusinessLayer
{
    public interface ITextsWriteService
    {
        Task<Result<TextRequestDTO>> Create(TextRequestDTO dto);
        Task<Result<TextRequestDTO>> Update(TextRequestDTO dto);
        Task<Result<Guid>> SoftDelete(Guid id);
        Task<Result<TextRequestDTO>> Delete(TextRequestDTO dto);
    }
}