﻿using LabWebApi.contracts.DTO.AdminPanel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWebApi.contracts.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductInfoDTO>> GetAllProductsAsync();
        Task<ProductInfoDTO> GetProductByIdAsync(int id);
        Task<ProductInfoDTO> EditProductAsync(UpdateProductDTO model, string userId, int id);
        Task DeleteProductAsync(int id, string userId);
        Task CreateProductAsync(CreateProductDTO model, string userId);
    }
}
