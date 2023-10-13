using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities.LinkEntities
{
    [PrimaryKey("TagId", "ProductId")]
    public class ProductTagEntity
    {
        public int TagId { get; set; }
        public TagEntity TagEntity { get; set; } = null!;

        public int ProductId { get; set; }
        public ProductEntity ProductEntity { get; set; } = null!;

    }
}
