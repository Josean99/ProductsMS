using DTOs.RequestDTOs;
using DTOs.ResponseDTOs;

namespace Test.Common.Fakes.DTOs
{
    public static class ProductImageDTOFake
    {
        #region Response
            public static List<ProductImageResponseDTO> GenerateFakeProductImagesResponseDTO()
            {
                var fakeProductImagesDTO = new List<ProductImageResponseDTO>
                {
                    new ProductImageResponseDTO
                    {
                        Id = Guid.NewGuid(),
                        Priority = 1,
                        IdProduct = Guid.NewGuid(),
                        IdImage = Guid.NewGuid(),
                        FechaBaja = null,
                    },
                    new ProductImageResponseDTO
                    {
                        Id = Guid.NewGuid(),
                        Priority = 2,
                        IdProduct = Guid.NewGuid(),
                        IdImage = Guid.NewGuid(),
                        FechaBaja = null,
                    }
                };

                return fakeProductImagesDTO;
            }
        #endregion

        #region Request
        public static List<ProductImageRequestDTO> GenerateFakeProductImagesRequestDTO()
        {
            var fakeProductImagesDTO = new List<ProductImageRequestDTO>
                {
                    new ProductImageRequestDTO
                    {
                        Id = Guid.NewGuid(),
                        Priority = 1,
                        IdProduct = Guid.NewGuid(),
                        IdImage = Guid.NewGuid(),
                        FechaBaja = null,
                    },
                    new ProductImageRequestDTO
                    {
                        Id = Guid.NewGuid(),
                        Priority = 2,
                        IdProduct = Guid.NewGuid(),
                        IdImage = Guid.NewGuid(),
                        FechaBaja = DateTime.Now,
                    }
                };

            return fakeProductImagesDTO;
        }
        #endregion
    }
}
