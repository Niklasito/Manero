using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manero.Models.Entities.LinkEntities;


[PrimaryKey(nameof(UserId), nameof(ReviewId))]
public class UserReviewEntity
{
   
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public ManeroUser User { get; set; } = null!;
    
    [ForeignKey(nameof(ReviewEntity))]
    public int ReviewId { get; set; }
    public ReviewEntity ReviewEntity { get; set; } = null!;
}
