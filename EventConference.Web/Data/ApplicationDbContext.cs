using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventConference.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<EventUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name="Guest",
                NormalizedName="GUEST"
            },
            new IdentityRole
            {
                Name= "Administrator",
                NormalizedName="ADMINISTRATOR"
            });

        }

        public static void SeedUserAdministrator(UserManager<EventUser> userManager)
        {
            if (userManager.FindByEmailAsync("helder@chebre.net").Result == null)
            {
                EventUser user = new EventUser
                {
                    UserName = "helder@chebre.net",
                    Email = "helder@chebre.net"
                };

                IdentityResult result = userManager.CreateAsync(user, "password").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }
    }
}
