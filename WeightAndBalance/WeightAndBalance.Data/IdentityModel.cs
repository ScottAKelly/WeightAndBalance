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

        public class CalculatorDbContext : IdentityDbContext
        {
            public CalculatorDbContext() : base ("DefaultConnection")
            { }

            public DbSet<AircraftEntity> Aircraft { get; set; }
            public DbSet<PayloadItemsEntity> PayloadItems { get; set; }
            public DbSet<PayloadEntity> Payload { get; set; }
        }
    }
}