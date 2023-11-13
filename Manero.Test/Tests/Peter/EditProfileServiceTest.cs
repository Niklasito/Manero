using Manero.Models.Entities.LinkEntities;
using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Manero.Models.Contexts;
using Manero.Helpers.Services;
using Manero.Models.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Manero.Helpers.Dtos;

namespace Manero.Test.Tests.Peter;

public class EditProfileServiceTest
{
    [Fact]
    public async Task GetAllAddressesOfOneUser_ReturnsCorrectAddresses()
    {
        // Arrange
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
            new Mock<IUserStore<ManeroUser>>().Object,
            null!, null!, null!, null!, null!, null!, null!, null!
        );

        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new DataContext(options))
        {
            context.UserAddresses.AddRange(
                new UserAddressEntity { UserId = "testUserId", AddressId = 1, AddressEntity = new AddressEntity { Id = 1, City = "TestCity1" } },
                new UserAddressEntity { UserId = "testUserId", AddressId = 2, AddressEntity = new AddressEntity { Id = 2, City = "TestCity2" } }
            );
            await context.SaveChangesAsync();
        }

        using (var context = new DataContext(options))
        {
            var service = new EditProfileService(userManagerMock.Object, context);

            // Act
            var result = await service.GetAllAddressesOfOneUser("testUserId");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Contains(result, address => address.City == "TestCity1");
            Assert.Contains(result, address => address.City == "TestCity2");
        }
    }


    [Fact]
    public async Task GetOneAddressesOfOneUser_ReturnsCorrectAddresses()
    {
        // Arrange
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
            new Mock<IUserStore<ManeroUser>>().Object,
            null!, null!, null!, null!, null!, null!, null!, null!
        );

        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase2")
            .Options;

        using (var context = new DataContext(options))
        {
            context.UserAddresses.AddRange(
                new UserAddressEntity { UserId = "testUserId", AddressId = 1, AddressEntity = new AddressEntity { Id = 1, City = "TestCity4" } },
                new UserAddressEntity { UserId = "testUserId", AddressId = 2, AddressEntity = new AddressEntity { Id = 2, City = "TestCity5" } }
            );
            await context.SaveChangesAsync();
        }

        using (var context = new DataContext(options))
        {
            var service = new EditProfileService(userManagerMock.Object, context);

            // Act
            var result = await service.GetOneAddressesOfOneUserAsync("testUserId");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("TestCity5", result.City);
        }
    }

    [Fact]
    public async Task UpdateUserAsync_UpdatesUserAndAddresses()
    {
        // Arrange
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
            new Mock<IUserStore<ManeroUser>>().Object,
            null!, null!, null!, null!, null!, null!, null!, null!
        );

        userManagerMock
                        .Setup(x => x.FindByIdAsync("a5928131-b297-43c8-9823-fd4e18a84b68"))
                        .ReturnsAsync((string userId) => new ManeroUser
                        {
                            Id = userId,
                            Name = "UpdatedName",
                            UserName = "updated@example.com",
                            PhoneNumber = "123456789"
                        });

        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase3")
            .Options;

        using (var context = new DataContext(options))
        {
            context.UserAddresses.AddRange(
                new UserAddressEntity { UserId = "a5928131-b297-43c8-9823-fd4e18a84b68", AddressId = 1, AddressEntity = new AddressEntity { Id = 1, City = "TestCity1" } },
                new UserAddressEntity { UserId = "a5928131-b297-43c8-9823-fd4e18a84b68", AddressId = 2, AddressEntity = new AddressEntity { Id = 2, City = "TestCity2" } }
            );
            await context.SaveChangesAsync();
        }

        using (var context = new DataContext(options))
        {
            var service = new EditProfileService(userManagerMock.Object, context);

            var model = new EditProfileModel
            {
                ProfileId = "a5928131-b297-43c8-9823-fd4e18a84b68",
                ProfileName = "UpdatedName",
                Email = "updated@example.com",
                PhoneNumber = "123456789",
                City = "TestCity3"
            };

            // Act
            var result = await service.UpdateUserAsync(model);

            // Assert
            Assert.True(result);

            var updatedUser = await userManagerMock.Object.FindByIdAsync("a5928131-b297-43c8-9823-fd4e18a84b68");
            Assert.NotNull(updatedUser);
            Assert.Equal("UpdatedName", updatedUser.Name);
            Assert.Equal("updated@example.com", updatedUser.UserName);
            Assert.Equal("123456789", updatedUser.PhoneNumber);

            var updatedAddresses = await service.GetAllAddressesOfOneUser("a5928131-b297-43c8-9823-fd4e18a84b68");
            Assert.NotNull(updatedAddresses);
            Assert.Equal(3, updatedAddresses.Count());

            var updatedCity = await service.GetOneAddressesOfOneUserAsync("a5928131-b297-43c8-9823-fd4e18a84b68");

            Assert.NotNull(updatedCity);
            Assert.Equal("TestCity3", updatedCity.City);
        }
    }

    [Fact]
    public async Task UpdateUserAsync_AddsNewAddressWhenCityDoesNotExist()
    {
        // Arrange
        var userManagerMock = new Mock<UserManager<ManeroUser>>(
            new Mock<IUserStore<ManeroUser>>().Object,
            null!, null!, null!, null!, null!, null!, null!, null!
        );

        userManagerMock
            .Setup(x => x.FindByIdAsync("a5928131-b297-43c8-9823-fd4e18a84b68"))
            .ReturnsAsync((string userId) => new ManeroUser
            {
                Id = userId,
                Name = "UpdatedName",
                UserName = "updated@example.com",
                PhoneNumber = "123456789"
            });

        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new DataContext(options))
        {
            
        }

        using (var context = new DataContext(options))
        {
            var service = new EditProfileService(userManagerMock.Object, context);

            var model = new EditProfileModel
            {
                ProfileId = "a5928131-b297-43c8-9823-fd4e18a84b68",
                ProfileName = "UpdatedName",
                Email = "updated@example.com",
                PhoneNumber = "123456789",
                City = "TestCity3" 
            };

            // Act
            var result = await service.UpdateUserAsync(model);

            // Assert
            Assert.True(result);

            var updatedUser = await userManagerMock.Object.FindByIdAsync("a5928131-b297-43c8-9823-fd4e18a84b68");
            Assert.NotNull(updatedUser);
            Assert.Equal("UpdatedName", updatedUser.Name);
            Assert.Equal("updated@example.com", updatedUser.UserName);
            Assert.Equal("123456789", updatedUser.PhoneNumber);

            var updatedAddresses = await service.GetAllAddressesOfOneUser("a5928131-b297-43c8-9823-fd4e18a84b68");
            Assert.NotNull(updatedAddresses);
            Assert.Single(updatedAddresses); 

            var updatedCity = await service.GetOneAddressesOfOneUserAsync("a5928131-b297-43c8-9823-fd4e18a84b68");

            Assert.NotNull(updatedCity);
            Assert.Equal("TestCity3", updatedCity.City); 
        }
    }


}

