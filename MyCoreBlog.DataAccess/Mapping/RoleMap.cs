using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCoreBlog.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.Mapping
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("43BAF319-D42A-4ABF-9AF7-BA8E0CF12950"),
                Name = "SuperAdmin",
                NormalizedName="SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString() /*aynı anda 2 kişi sistemde role değişikliği yapmak isterse milisaniye cinsiden ayrılmalarını sağlar*/
            },
            new AppRole
            {
                Id = Guid.Parse("F6B8AA2A-096D-4F04-AA42-2F4AD123E7E0"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString() /*aynı anda 2 kişi sistemde role değişikliği yapmak isterse milisaniye cinsiden ayrılmalarını sağlar*/

            }, 
            new AppRole
            {
                Id = Guid.Parse("773EEE07-E9EB-40CE-89BA-D6CC375233CF"),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString() /*aynı anda 2 kişi sistemde role değişikliği yapmak isterse milisaniye cinsiden ayrılmalarını sağlar*/

            }); 
        }
    }
}
