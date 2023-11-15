using Manero.Controllers;
using Manero.Models.Contexts;
using Manero.Models.Entities;
using Manero.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Manero.Test.Tests.Diana
{
    [TestClass]
    internal class AddToCartTests
    {
        [TestMethod]
        public void AddToCart_WhenProductExists_ShouldAddToCartAndSetTempData()
        {
            // Arrange
            var productId = 1;
            var product = new ProductEntity { Id = productId, Name = "TestProduct", Price = 10.0m };

            var mockContext = new Mock<DataContext>();
            mockContext.Setup(c => c.Products.Find(productId)).Returns(product);

            var mockCart = new Mock<Cart>();
            var controller = new CartController(mockContext.Object, mockCart.Object);

            // Act
            var result = controller.AddToCart(productId) as RedirectToActionResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Index", result.ActionName);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Cart", result.ControllerName);

            mockContext.Verify(c => c.Products.Find(productId), Times.Once);
            mockCart.Verify(c => c.AddItem(product), Times.Once);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual($"TestProduct added to cart.", controller.TempData["AddedToCartMessage"]);
        }

        [TestMethod]
        public void AddToCart_WhenProductDoesNotExist_ShouldNotAddToCartAndNotSetTempData()
        {
            // Arrange
            var productId = 1;

            var mockContext = new Mock<DataContext>();
            mockContext.Setup(c => c.Products.Find(productId)).Returns((ProductEntity)null);

            var mockCart = new Mock<Cart>();
            var controller = new CartController(mockContext.Object, mockCart.Object);

            // Act
            var result = controller.AddToCart(productId) as RedirectToActionResult;

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(result);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Index", result.ActionName);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Cart", result.ControllerName);

            mockContext.Verify(c => c.Products.Find(productId), Times.Once);
            mockCart.Verify(c => c.AddItem(It.IsAny<ProductEntity>()), Times.Never);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(controller.TempData["AddedToCartMessage"]);
        }
    }
}

