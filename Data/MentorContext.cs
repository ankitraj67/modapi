using MentorOnDemand.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MentorOnDemand.Data
{
    public class MentorContext : IdentityDbContext
    {
        public MentorContext([NotNullAttribute]
        DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>(r => r.HasData(new IdentityRole
            {
                Id = "1",
                Name = "Admin",
                NormalizedName = "Admin"
            },
            new IdentityRole
            {
                Id = "2",
                Name = "Mentor",
                NormalizedName = "Mentor"

            },
            new IdentityRole
            {
                Id = "3",
                Name = "Student",
                NormalizedName = "Student"
            }
            ));

            base.OnModelCreating(builder);
        }
        public DbSet<UserMod> UserMods { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
