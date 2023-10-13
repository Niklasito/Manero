using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace Manero.Models.Entities;

[PrimaryKey("ManeroUserId", "ReviewId")]
public class UserReviewEntity
{
    public int ReviewId { get; set; }
    public ReviewEntity ReviewEntity { get; set; } = null!;

    public int ManeroUserId { get; set; }

    public ManeroUser ManeroUser { get; set; } = null!;
}
