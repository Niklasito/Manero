using Manero.Models.Entities.Identity;
using Manero.Models.ViewModels;

namespace Manero.Test.Tests.Niklas;

public class UserTests
{

    [Fact]
    public void UserCreateAccountViewModel_Should_Convert_To_Manero_User()
    {
        //Arrange
        UserCreateAccountViewModel model = new UserCreateAccountViewModel()
        {

            Password = "Password1!",
            ConfirmPassword = "Password1!",
            Name = "Niklas Andersson",
            Email = "Niklas@domain.com"
        };

        //Act
        ManeroUser user = model;


        //Assert
        Assert.NotNull(user);
        Assert.IsType<ManeroUser>(user);
        Assert.Equal(model.Email, user.Email);
        Assert.Equal(model.Password, model.ConfirmPassword);
        Assert.Equal(model.Name, user.Name);

    }


}
