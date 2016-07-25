using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AircraftBalance.Data
{
    public class IdentityModel
    {
        public class WeightAndBalanceAppUser : IdentityUser
        {
            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<WeightAndBalanceAppUser> manager)
            {
                // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Add custom user claims here
                return userIdentity;
            }
        }

        public class WeightAndBalanceDbContext : IdentityDbContext<WeightAndBalanceAppUser>
        {
            public WeightAndBalanceDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static WeightAndBalanceDbContext Create()
            {
                return new WeightAndBalanceDbContext();
            }

            // Entities.
            public DbSet<Aircraft> Aircraft { get; set; }
            public DbSet<Payload> Payload { get; set; }
            public DbSet<PayloadItem> PayloadItems { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                modelBuilder
                    .Configurations
                        .Add(new IdentityUserLoginConfiguration())
                        .Add(new IdentityUserRoleConfiguration());
            }
        }

        public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
        {
            public IdentityUserLoginConfiguration()
            {
                HasKey(iul => iul.UserId);
            }
        }

        public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
        {
            public IdentityUserRoleConfiguration()
            {
                HasKey(iur => iur.RoleId);
            }
        }
    }
}