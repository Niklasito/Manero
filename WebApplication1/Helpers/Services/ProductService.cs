using Manero.Helpers.Dtos;
using Manero.Helpers.Repositories;
using Manero.Models.Contexts;
using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Helpers.Services;

public class ProductService
{
    private readonly DataContext _context;
    private readonly ProductRepository _productRepository;

    public ProductService(DataContext context, ProductRepository productRepository)
    {
        _context = context;
        _productRepository = productRepository;
    }

    public async Task<ProductEntity> GetProductAsync(string ProductName)
    {
        var product = await _context.Products.FirstOrDefaultAsync(x => x.Name == ProductName);
        if (product != null)
        {
            return product;
        }

        return product!;
    }

    public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
    {
        var products = new List<ProductModel>();
        var items = await _context.Products.ToListAsync();
        foreach (var item in items)
        {
            ProductModel productModel = item;
            products.Add(productModel);
        }

        return products;
    }

    public async Task<IEnumerable<ProductModel>> GetProductsWithImagesAsync()
    {
         var products = await _context.ProductImages
         .Include(x => x.ImageEntity)
         .Select(x => new ProductModel
         {
             Id = x.ProductEntity.Id,
             Name = x.ProductEntity.Name,
             ArticleNumber = x.ProductEntity.ArticleNumber,
             Description = x.ProductEntity.Description,
             Price = x.ProductEntity.Price,
             ImageUrl = x.ImageEntity.ImageUrl
         })
         .ToListAsync();

            return products;
    }
}
