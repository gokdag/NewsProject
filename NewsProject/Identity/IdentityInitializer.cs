using Microsoft.AspNetCore.Identity;
using NewsProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.Identity
{
    public class IdentityInitializer
    {
        public static void CreateAdmin(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            AppUser appUser = new AppUser
            {
                Name = "Kerim Can",
                Surname = "Gökdağ",
                UserName = "kgokdag"
            };
            if (userManager.FindByNameAsync("Kerim").Result == null)
            {
                var IdentityREsult =userManager.CreateAsync(appUser,"1").Result;
            }
            if (roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin",
                };
               var identityResult= roleManager.CreateAsync(role).Result;

                var ResultUserManager= userManager.AddToRoleAsync(appUser, role.Name).Result;
            }
        }

    }
}
