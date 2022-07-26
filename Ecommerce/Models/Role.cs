using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public static class Role
    {
        public static async Task seedRoleDB(IApplicationBuilder applicationBuilder)
        {
            using (var servicesSocet = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManger = servicesSocet.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await roleManger.RoleExistsAsync("Admin"))
                {
                    await roleManger.CreateAsync(new IdentityRole("Admin"));
                }
                if (!await roleManger.RoleExistsAsync("user"))
                {
                    await roleManger.CreateAsync(new IdentityRole("user"));
                }
            }
        }

    }
}
