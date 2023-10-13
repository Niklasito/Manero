using Manero.Models.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Manero.Models.Entities.LinkEntities;


[PrimaryKey(nameof(UserId), nameof(AddressId))]
public class UserAddressEntity
{
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public ManeroUser User { get; set; } = null!;

    [ForeignKey(nameof(AddressEntity))]
    public int AddressId { get; set; }
    public AddressEntity AddressEntity { get; set; } = null!;
}
