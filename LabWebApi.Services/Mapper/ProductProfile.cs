using AutoMapper;
using LabWebApi.contracts.Data.Entities;
using LabWebApi.contracts.DTO.AdminPanel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavWevApi.Services.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDTO, Product>();
            CreateMap<UpdateProductDTO, Product>();
            CreateMap<ProductInfoDTO, Product>();
            CreateMap<Product, ProductInfoDTO>();
        }
    }
}
