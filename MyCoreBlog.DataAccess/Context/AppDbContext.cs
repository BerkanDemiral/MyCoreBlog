using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCoreBlog.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.Context
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,Guid,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // mapping içerisindeki işlermleri daha derleme olmadan mevcut assembly içeriisnde olduğu için bulup işleyecek.
        }
    }
}
