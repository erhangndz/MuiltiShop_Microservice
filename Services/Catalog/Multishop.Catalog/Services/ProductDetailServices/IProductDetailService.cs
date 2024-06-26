﻿using Multishop.Catalog.Dtos.ProductDetailDtos;
using Multishop.Catalog.Entities;

namespace Multishop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService : IRepository<ProductDetail>
    {

        Task<List<ResultProductDetailDto>> GetDetailsByProductIdAsync(string id);
    }
}
