﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntiyLAyer.Entities;
using SignalR.DataAccsessLayer.Concrete;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }
        [HttpGet("ProductCount")]

        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

        [HttpGet("productNameByMaxPrice")]

        public IActionResult productNameByMaxPrice()
        {
            return Ok(_productService.TproductNameByMaxPrice());
        }

        [HttpGet("productNameByMinPrice")]

        public IActionResult productNameByMinPrice()
        {
            return Ok(_productService.TproductNameByMinPrice());
        }


        [HttpGet("ProductAvgPriceByHamburger")]

        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());
        }

        [HttpGet("ProductCountByHamburger")]

        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }

        [HttpGet("ProductCountByDrink")]

        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDirnk());
        }

        [HttpGet("ProductPriceAvg")]

        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }



        [HttpGet("ProductListWithCategory")]

        public IActionResult ProductListWithCategory()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }

        [HttpPost]

        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description=createProductDto.Description,
                ImageUrl=createProductDto.ImageUrl,
                Price=createProductDto.Price,
                ProductName=createProductDto.ProductName,
                ProductStatus=createProductDto.ProductStatus,
                CategoryID=createProductDto.CategoryID
            });
            return Ok("Ürün Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Bilgisi Silindi");
        }
        [HttpGet("{id}")]

        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]

        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                ProductID=updateProductDto.ProductID,
                CategoryID=updateProductDto.CategoryID
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }
    }
}





