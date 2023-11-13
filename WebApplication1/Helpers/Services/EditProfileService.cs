using Manero.Helpers.Dtos;
using Manero.Models.Contexts;
using Manero.Models.Entities;
using Manero.Models.Entities.Identity;
using Manero.Models.Entities.LinkEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Manero.Helpers.Services;


public interface InterfaceEdietProfileService
{
    Task<bool> UpdateUserAsync(EditProfileModel model);
    Task<AddressEntity> GetOneAddressesOfOneUserAsync(string userId);
    Task<IEnumerable<AddressEntity>> GetAllAddressesOfOneUser(string userId);
}

public class EditProfileService : InterfaceEdietProfileService
{
    private readonly UserManager<ManeroUser> _userManager;
    private readonly DataContext _context;

    public EditProfileService(UserManager<ManeroUser> userManager, DataContext context)
    {
        _userManager=userManager;
        _context=context;
    }

    public async Task<bool> UpdateUserAsync(EditProfileModel model)
    {
        try
        {
            var existingUser = await _userManager.FindByIdAsync(model.ProfileId);

            if (existingUser != null)
            {
                existingUser.Name = model.ProfileName;
                existingUser.UserName = model.Email;
                existingUser.PhoneNumber = model.PhoneNumber;


                var allAddresses = await GetAllAddressesOfOneUser(existingUser.Id);

                var existingAddress = allAddresses.FirstOrDefault(a => a.City == model.City);

                if (existingAddress != null)
                {
                    var newAddress = new AddressEntity
                    {
                        StreetName = existingAddress.StreetName,
                        StreetNumber = existingAddress.StreetNumber,
                        City = existingAddress.City,
                        PostalCode = existingAddress.PostalCode,
                        Country = existingAddress.Country
                    };

                    var newUserAddress = new UserAddressEntity
                    {
                        UserId = existingUser.Id,
                        AddressEntity = newAddress
                    };
                    _context.UserAddresses.Add(newUserAddress);
                    _context.Addresses.Remove(existingAddress);
                    _context.UserAddresses.Remove(existingUser.UserAddresses.First()); 
                }
                else
                {
                    var newAddress = new AddressEntity { City = model.City };
                    var newUserAddress = new UserAddressEntity
                    {
                        UserId = existingUser.Id,
                        AddressEntity = newAddress
                    };
                    _context.UserAddresses.Add(newUserAddress);
                }

                await _userManager.UpdateAsync(existingUser);
                await _context.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public async Task<AddressEntity> GetOneAddressesOfOneUserAsync(string userId)
    {
        try
        {
            if (userId != null)
            {
                var addressList = await _context.UserAddresses
                .Include(ua => ua.AddressEntity)
                .Where(x => x.UserId == userId)
                .ToListAsync();
                return addressList.LastOrDefault()?.AddressEntity!;
            }
            else
            {
                return null!;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }

    }
        
    public async Task<IEnumerable<AddressEntity>> GetAllAddressesOfOneUser(string userId)
    {
        try
        {
            if (userId != null)
            {
                var userAddressList = await _context.UserAddresses
                    .Include(ua => ua.AddressEntity)
                    .Where(x => x.UserId == userId)
                    .ToListAsync();

                return userAddressList.Select(ua => ua.AddressEntity);
            }
            else
            {
                return null!;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }
    }
}
