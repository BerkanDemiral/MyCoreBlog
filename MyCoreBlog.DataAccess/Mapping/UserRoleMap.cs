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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {

        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole { 
                UserId = Guid.Parse("C293C647-06B4-42D5-9431-D31353E35B0C"),
                RoleId = Guid.Parse("43BAF319-D42A-4ABF-9AF7-BA8E0CF12950")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("A5C9C789-54CF-4CA4-A274-1F3EDD3B7C15"),
                RoleId = Guid.Parse("F6B8AA2A-096D-4F04-AA42-2F4AD123E7E0")
            });
        }
    }
}
