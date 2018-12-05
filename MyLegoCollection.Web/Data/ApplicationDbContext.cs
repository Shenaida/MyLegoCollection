using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLegoCollection.Web.Data.Entities;
using MyLegoCollection.Web.Models;
using Vanguard.Framework.Core.Repositories;
using Vanguard.Framework.Data.Repositories;

namespace MyLegoCollection.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LegoSet> LegoSets { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        //IRepository<LegoSet> legosetRepository = new Repository<LegoSet>(new IdentityDbContext());
    }
}
