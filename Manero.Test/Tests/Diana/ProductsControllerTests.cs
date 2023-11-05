using Manero.Controllers;
using Manero.Models.Contexts;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Manero.Models.Entities;

namespace Manero.Tests.Controllers
{
    public class ProductsControllerTests
    {
        [Fact]
        public void Search_ReturnsViewResult_WithListOfProducts()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new DataContext(options))
            {
                // Populate the database with test data
                context.Products.AddRange(
                    new ProductEntity { ArticleNumber = "123", Name = "Test Product 1", Description = "This is a test product." },
                    new ProductEntity { ArticleNumber = "456", Name = "Test Product 2", Description = "This is another test product." }
                );
                context.SaveChanges();
            }

            var controller = new ProductsController(new DataContext(options));
            var query = "test";

            // Act
            var result = controller.Search(query) as ViewResult;
            var actualProducts = result.Model as List<ProductEntity>;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("SearchResults", result.ViewName);

            // Check the actual products returned in the ViewResult
            Assert.Collection(actualProducts, item =>
            {
                Assert.Equal("123", item.ArticleNumber);
                Assert.Equal("Test Product 1", item.Name);
                Assert.Equal("This is a test product.", item.Description);
            }, item =>
            {
                Assert.Equal("456", item.ArticleNumber);
                Assert.Equal("Test Product 2", item.Name);
                Assert.Equal("This is another test product.", item.Description);
            });
        }
    }
}
