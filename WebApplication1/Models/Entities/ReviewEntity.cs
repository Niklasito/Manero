namespace Manero.Models.Entities;

public class ReviewEntity
{
    public int Id { get; set; }
    public DateTime DateTime{ get; set; } = DateTime.Now;
    public string Comment { get; set; } = null!;
    public int Rating { get; set; }

    public ICollection<ProductReviewEntity> ProductReviews { get; set; } = new HashSet<ProductReviewEntity>();

}
