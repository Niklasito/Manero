using Manero.Models.Entities;

namespace Manero.Helpers.Dtos;

public class ProductModel
{
    
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? ArticleNumber { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<ImagesModel> Images { get; set; } = new HashSet<ImagesModel>();

        public ICollection<CategoriesModel> Categories { get; set; } = new HashSet<CategoriesModel>();

        public ICollection<TagsModel> Tags { get; set; } = new HashSet<TagsModel>();
    public ImageEntity? PrimaryImage { get; internal set; }
}
