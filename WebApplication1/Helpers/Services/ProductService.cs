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

    public async Task<IEnumerable<ProductModel>> GetProductsWithImagesCategoriesAndTagsAsync()
   
    {
        var products = await _context.Products
            .Include(x => x.ProductImages)
            .Include(x => x.ProductCategories)
            .Include(x => x.ProductTags)
            .Select(x => new ProductModel
            {
                Id = x.Id,
                Name = x.Name,
                ArticleNumber = x.ArticleNumber,
                Description = x.Description,
                Price = x.Price,
                ImageUrl = x.ProductImages.FirstOrDefault() != null
                    ? x.ProductImages.First().ImageEntity.ImageUrl
                    : null,
                Categories = x.ProductCategories.Select(x => new CategoriesModel
                {
                    CategoryId = x.CategoryEntity.Id,
                    CategoryName = x.CategoryEntity.Name
                }).ToList(),
                Tags = x.ProductTags.Select(x => new TagsModel
                {
                    TagsId = x.TagEntity.Id,
                    TagName = x.TagEntity.Name
                }).ToList(),
            })
            .ToListAsync();

        return products;
    }

    public async Task<IEnumerable<ProductModel>> GetBestSellingProductsAsync()
    {
        var products = await _context.Products
       .Include(x => x.ProductTags)
       .Where(x => x.ProductTags.Any(tag => tag.TagId == 1))
       .Select(x => new ProductModel
       {
           Id = x.Id,
           Name = x.Name,
           ArticleNumber = x.ArticleNumber,
           Description = x.Description,
           Price = x.Price,
           ImageUrl = x.ProductImages.FirstOrDefault() != null
               ? x.ProductImages.First().ImageEntity.ImageUrl
               : null,
           Tags = x.ProductTags.Select(x => new TagsModel
           {
               TagsId = x.TagEntity.Id,
               TagName = x.TagEntity.Name
           }).ToList(),
       })
       .ToListAsync();
        return products;
    }

    public async Task<IEnumerable<ProductModel>> GetFeaturedProductsAsync()
    {
        var products = await _context.Products
         .Include(x => x.ProductTags)
         .Include(x => x.ProductImages)
         .ThenInclude(x => x.ImageEntity)
         .Where(x => x.ProductTags.Any(tag => tag.TagId == 2))
         .ToListAsync();

        return products.Select(item => new ProductModel
        {
            Id = item.Id,
            Name = item.Name,
            ArticleNumber = item.ArticleNumber,
            Description = item.Description,
            Price = item.Price,
            ImageUrl = item.ProductImages
                .Select(x => x.ImageEntity.ImageUrl)
                .FirstOrDefault()
        }).ToList();
    }
}
