using DTOs.RequestDTOs;
using DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Common.Fakes.DTOs
{
    public static class CategoryDTOFake
    {
        #region Response
            public static CategoryResponseDTO GenerateFakeCategoryResponseDTO()
            {
                var fakeCategoryDTO = new CategoryResponseDTO
                {
                    Id = Guid.NewGuid(),
                    Name = "Fake Category",
                    Icon = "fa fa-folder",
                    IdImage = Guid.NewGuid(),
                    IdFatherCategory = Guid.NewGuid(),
                    FechaBaja = null
                };

                return fakeCategoryDTO;
            }
        #endregion

        #region Request
        public static CategoryRequestDTO GenerateFakeCategoryRequestDTO()
        {
            var fakeCategoryDTO = new CategoryRequestDTO
            {
                Id = Guid.NewGuid(),
                Name = "Fake Category",
                Icon = "fa fa-folder",
                IdImage = Guid.NewGuid(),
                IdFatherCategory = Guid.NewGuid(),
                FechaBaja = null
            };

            return fakeCategoryDTO;
        }
        #endregion

    }
}
