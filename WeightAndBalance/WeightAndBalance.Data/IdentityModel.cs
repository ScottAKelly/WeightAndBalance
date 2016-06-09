using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace WeightAndBalance.Data
{
    public class IdentityModel 
    {
        public class CalculatorUser : IdentityUser
        {
            public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<CalculatorUser> manager)
            {
                // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
                var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
                // Add custom user claims here
                return userIdentity;
            }
        }

        public CalculatorDbContext Create()
        {
            return new CalculatorDbContext();
        }

        public class CalculatorDbContext : IdentityDbContext<CalculatorUser>
        {
            public CalculatorDbContext() : base ("DefaultConnection", throwIfV1Schema: false)
            { }

            public DbSet<AircraftEntity> Aircraft { get; set; }
            public DbSet<PayloadItems> PayloadItems { get; set; }
            public DbSet<Payload> Payload { get; set; }
        }
    }
}