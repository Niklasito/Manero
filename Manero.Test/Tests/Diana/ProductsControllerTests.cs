﻿using Manero.Controllers;
using Manero.Models.Contexts;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Manero.Models.Entities;
using Manero.Helpers.Dtos;

namespace Manero.Tests.Controllers
{
    public class ProductsControllerUnitTests
    {
        [Fact]
        public void Search_ReturnsViewResult_WithListOfProducts()
        {
            var dbContextOptions = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new DataContext(dbContextOptions))
            {
                context.Products.Add(new ProductEntity
                {
                    Id = 1,
                    Name = "TestProduct",
                    Description = "TestDescription",
                    Price = 10.0m,
                    ArticleNumber = "TestArticleNumber" 
                                                      
                });
                context.SaveChanges();
            }

            var controller = new ProductsController(new DataContext(dbContextOptions));

            var result = controller.Search("Test") as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<List<ProductModel>>(result.Model);
        }
    }

}
