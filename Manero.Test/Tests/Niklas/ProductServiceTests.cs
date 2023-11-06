using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manero.Helpers.Dtos;
using Manero.Helpers.Repositories;
using Manero.Helpers.Services;
using Manero.Models.Contexts;
using Manero.Models.Entities;
using Manero.Models.Entities.LinkEntities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace Manero.Test.Tests.Niklas;

public class ProductServiceTests
{

    [Fact]
    public async Task Get_BestSellingProductsAsync_Should_Return_Products_With_BestSelling_Tag()
    {
        
        // Arrange
        var options = new DbContextOptionsBuilder<DataContext>()
           .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
           .Options;

        using (var context = new DataContext(options))
        {
            context.Database.EnsureCreated();

            var products = new List<ProductEntity>
        {
            new ProductEntity
            {
                Id = 1,
                Name = "Test Product",
                ArticleNumber = "123456",
                Description = "Test Description",
                Price = 100,
                ProductTags = new List<ProductTagEntity>
                {
                    new ProductTagEntity
                    {
                        TagId = 1,
                        TagEntity = new TagEntity { Name = "Best Sellers" }
                    }
                }
            }
        };

            context.Products.AddRange(products);
            context.SaveChanges();
            var productRepo = new ProductRepository(context);
            var productService = new ProductService(context, productRepo);

            // Act
            var result = await productService.GetBestSellingProductsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("Test Product", result.First().Name);
            Assert.Equal(100, result.First().Price);

            var tags = result.First().Tags;
            Assert.NotNull(tags);
            Assert.NotEmpty(tags);

            var expectedTagId = 1;
            var expectedTagName = "Best Sellers";

            var firstProduct = result.FirstOrDefault();
            var realTag = firstProduct?.Tags.First();

            Assert.NotNull(firstProduct);
            Assert.Equal(expectedTagId, realTag?.TagsId);
            Assert.Equal(expectedTagName, realTag?.TagName);

        }
    }


    [Fact]
    public async Task Get_All_Products_Async_Should_Return_Products()
    {

        //Arrange
        var options = new DbContextOptionsBuilder<DataContext>()
           .UseInMemoryDatabase(databaseName: "FakeDb")
           .Options;

        using (var context = new DataContext(options))
        {
            context.Database.EnsureCreated();

            var products = new List<ProductEntity>
            {
                new ProductEntity
                {
                    Id = 1,
                    Name = "Test Product",
                    Description = "This is a test description",
                    Price = 99,
                    ArticleNumber = "123456",

                },
                new ProductEntity
                {
                    Id = 2,
                    Name = "Test Product 2",
                    Description = "This is a second test description",
                    Price = 100,
                    ArticleNumber = "987654",

                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            var productRepo = new ProductRepository(context);
            var productService = new ProductService(context, productRepo);

            //Act

            var result = await productService.GetAllProductsAsync();


            //Assert

            var singleProduct = result.First();

            Assert.NotNull(result);
            Assert.IsType<List<ProductModel>>(result);
            Assert.Equal(singleProduct.Name, products.First().Name);
            Assert.Equal(singleProduct.Id, products.First().Id);
            Assert.Equal(singleProduct.Description, products.First().Description);
            Assert.Equal(singleProduct.Price, products.First().Price);
            Assert.Equal(singleProduct.ArticleNumber, products.First().ArticleNumber);

            var multipleProducts = result.ToList();

            Assert.NotEmpty(multipleProducts);
            Assert.Equal(2, multipleProducts.Count());
            Assert.Equal("Test Product", multipleProducts[0].Name);
            Assert.Equal("Test Product 2", multipleProducts[1].Name);
            Assert.Equal("123456", multipleProducts[0].ArticleNumber);
            Assert.Equal("987654", multipleProducts[1].ArticleNumber);

        }

    }
}