using LabWebApi.contracts.Roles;
using LabWebApi.contracts.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace LabWevAPI.Database.Seeding
{
    public static class SeedingRoles
    {
        public static async Task SystemRoles(UserManager<User> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(AuthorizationRoles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AuthorizationRoles.Buyer.ToString()));
            await roleManager.CreateAsync(new IdentityRole(AuthorizationRoles.Seller.ToString()));
            var admin = new User
            {
                Name = "Admin",
                Surname = "Admin",
                UserName = "Admin",
                Email = "admin@admin.com",
                Birthday = DateTime.Now,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != admin.Id))
            {
                await userManager.CreateAsync(admin, "Admin1!");
                await userManager.AddToRoleAsync(admin, AuthorizationRoles.Admin.ToString());
            }
        }
    }
}