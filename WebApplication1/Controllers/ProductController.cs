﻿using LabWebApi.contracts.Data.Entities;
using LabWebApi.contracts.DTO.AdminPanel.Product;
using LabWebApi.contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApplication1.Controllers
{
      [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private string UserId => User.FindFirst(ClaimTypes.NameIdentifier).Value;

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _productService.GetAllProductsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDTO model)
        {
            await _productService.CreateProductAsync(model, UserId);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> EditProduct([FromBody] UpdateProductDTO model, int id)
        {
            var result = await _productService.EditProductAsync(model, UserId, id);
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _productService.DeleteProductAsync(id, UserId);
            return Ok();
        }
    }
}
