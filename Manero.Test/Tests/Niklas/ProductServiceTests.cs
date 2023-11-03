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
}