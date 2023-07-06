using DTOs.RequestDTOs;
using EntityService.Model;
using Infrastructure.WebApiServices.Results;

namespace IWriteBusinessLayer
{
    public interface IImagesWriteService
    {
        Task<Result<ImageRequestDTO>> Create(ImageRequestDTO dto);
        Task<Result<ImageRequestDTO>> Update(ImageRequestDTO dto);
        Task<Result<Guid>> SoftDelete(Guid id);
        Task<Result<ImageRequestDTO>> Delete(ImageRequestDTO dto);
    }
}