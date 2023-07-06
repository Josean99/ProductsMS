using DTOs.RequestDTOs;
using EntityService.Model;
using Infrastructure.WebApiServices.Results;

namespace IWriteBusinessLayer
{
    public interface IProductsWriteService
    {
        Task<Result<ProductRequestDTO>> Create(ProductRequestDTO dto);
        Task<Result<ProductWithImagesRequestDTO>> CreateProductWithImages(ProductWithImagesRequestDTO productWithImagesDTO);
        Task<Result<ProductRequestDTO>> Update(ProductRequestDTO dto);
        Task<Result<ProductWithImagesRequestDTO>> UpdateProductWithImages(ProductWithImagesRequestDTO productWithImagesDTO);
        Task<Result<Guid>> SoftDelete(Guid id);
        Task<Result<Guid>> SoftDeleteWithImages(Guid id);
        Task<Result<ProductRequestDTO>> Delete(ProductRequestDTO dto);
    }
}