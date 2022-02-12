using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace MyWarehouse.Infrastructure.Authorization
{
    // TODO: Implement authorization system, actually preferably in Application layer; if a good, simple use case can be established in this sample project.
    [ExcludeFromCodeCoverage]
    internal static class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration _)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy(Constants.PolicyNames.Administrator, policy => policy.RequireClaim(Constants.KnownClaims.AdministartorClaim.Name));
                options.AddPolicy(Constants.PolicyNames.FullEditor, policy =>
                    policy.RequireClaim(Constants.KnownClaims.PermissionClaim.Name, Constants.KnownClaims.PermissionClaim.Values.EditProducts)
                            .RequireClaim(Constants.KnownClaims.PermissionClaim.Name, Constants.KnownClaims.PermissionClaim.Values.EditPrices)
                            .RequireClaim(Constants.KnownClaims.PermissionClaim.Name, Constants.KnownClaims.PermissionClaim.Values.EditPartners));
            });
        }

        public static void Configure(this IApplicationBuilder app)
        {
            app.UseAuthorization();
        }
    }
}
