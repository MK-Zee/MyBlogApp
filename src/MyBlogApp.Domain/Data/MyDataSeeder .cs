using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.Uow;

namespace MyBlogApp.Data
{
    public class MyDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IdentityUserManager _userManager;
        private readonly IdentityRoleManager _roleManager;
        private readonly IGuidGenerator _guidGenerator;

        public MyDataSeeder(
            IdentityUserManager userManager,
            IdentityRoleManager roleManager,
            IGuidGenerator guidGenerator)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _guidGenerator = guidGenerator;
        }

        [UnitOfWork]
        public async Task SeedAsync(DataSeedContext context)
        {
            // Ensure admin role exists
            var adminRole = await _roleManager.FindByNameAsync("admin");
            if (adminRole == null)
            {
                adminRole = new IdentityRole(_guidGenerator.Create(), "admin", context.TenantId)
                {
                    IsStatic = true,
                    IsDefault = true
                };

                await _roleManager.CreateAsync(adminRole);
            }

            // Ensure admin user exists
            var adminUser = await _userManager.FindByNameAsync("test");
            if (adminUser == null)
            {
                adminUser = new IdentityUser(
                    _guidGenerator.Create(),
                    "test",
                    "test@mydomain.com",
                    context.TenantId
                );

                adminUser.AddRole(adminRole.Id);
                (await _userManager.CreateAsync(adminUser, "1q2w3E*")).CheckErrors();
            }
        }
    }
}
