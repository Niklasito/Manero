
using Manero.Models.Entities.LinkEntities;

namespace Manero.Models.Entities;

public class AddressEntity
{
    public int Id { get; set; }
    public string? StreetName { get; set; } 
    public string? StreetNumber { get; set; } 
    public string? City { get; set; } 
    public string? PostalCode { get; set; } 
    public string? Country { get; set; } 

    public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();
}
