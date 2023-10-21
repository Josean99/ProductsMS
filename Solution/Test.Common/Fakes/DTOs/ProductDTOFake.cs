using DTOs.RequestDTOs;
using DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Common.Fakes.DTOs
{
    public static class ProductDTOFake
    {
        #region Response
        public static ProductResponseDTO GenerateFakeProductResponseDTO()
        {
            var fakeProductDTO = new ProductResponseDTO
            {
                Id = Guid.NewGuid(),
                Name = "Fake Product",
                Description = "This is a fake product",
                IdCategory = Guid.NewGuid(),
                IdBrand = Guid.NewGuid(),
                FechaBaja = DateTime.Now
            };

            return fakeProductDTO;
        }
        #endregion

        #region Request
        public static ProductRequestDTO GenerateFakeProductRequestDTO()
            {
                var fakeProductDTO = new ProductRequestDTO
                {
                    Id = Guid.NewGuid(),
                    Name = "Fake Product",
                    Description = "This is a fake product",
                    IdCategory = Guid.NewGuid(),
                    IdBrand = Guid.NewGuid(),
                    FechaBaja = DateTime.Now
                };

                return fakeProductDTO;
            }

        public static ProductWithImagesRequestDTO GenerateFakeProductWithImagesRequestDTO()
        {
            var fakeProductDTO = new ProductWithImagesRequestDTO
            {
                Id = Guid.NewGuid(),
                Name = "Fake Product",
                Description = "This is a fake product",
                IdCategory = Guid.NewGuid(),
                IdBrand = Guid.NewGuid(),
                FechaBaja = DateTime.Now,

                ProductImages = ProductImageDTOFake.GenerateFakeProductImagesRequestDTO()
            };

            return fakeProductDTO;
        }
        #endregion

    }
}
