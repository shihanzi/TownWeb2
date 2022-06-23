using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
       public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
       {
        if (!userManager.Users.Any())
        {
                    var user = new AppUser
                {
                    DisplayName = "shihan",
                    Email = "shihanmails@gmai.com",
                    UserName = "shihanmails@gmai.com",
                    Address = new Address
                    {
                        FirstName = "shihan",
                        LastName = "Mohamed",
                        Street = "Church Rd",
                        City = "Colombo",
                        State = "Western",
                        ZipCode = "01500"
                    }
                };
                await userManager.CreateAsync(user, "1234");
        }
       } 
    }
}