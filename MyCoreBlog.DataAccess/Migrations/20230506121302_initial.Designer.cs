﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCoreBlog.DataAccess.Context;

#nullable disable

namespace MyCoreBlog.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230506121302_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("43baf319-d42a-4abf-9af7-ba8e0cf12950"),
                            ConcurrencyStamp = "0c4c36a1-d357-4fbc-b59a-ece88121086f",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("f6b8aa2a-096d-4f04-aa42-2f4ad123e7e0"),
                            ConcurrencyStamp = "a8d98478-fc25-4fb5-b717-59cb4edbc0c8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("773eee07-e9eb-40ce-89ba-d6cc375233cf"),
                            ConcurrencyStamp = "a9aabf0b-756b-48ef-b5b3-fafc513206cf",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c293c647-06b4-42d5-9431-d31353e35b0c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5746153c-b31e-4571-87ae-24b58c9fb235",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Berkan",
                            ImageId = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            LastName = "Superadmin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPNt6Rw7zSwmvC9eqiCRGqRmYsnp67ijxvoEaWkszJixBVu4grgqhS/xf1AcjlhO0Q==",
                            PhoneNumber = "+05322122399",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "9fb294c7-708e-4b1c-8391-392515ea9677",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("a5c9c789-54cf-4ca4-a274-1f3edd3b7c15"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "80c856c5-85de-4037-a33a-32eb3236c445",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Berkan",
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP+wZI443OWb0ejsadbHB3ljZROqImohissDx5DSSk2duIyqC0+oLWv/h2AkKkbzzA==",
                            PhoneNumber = "+0595959565",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "b12428d9-d000-42ef-82f3-454b895ddd4e",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("c293c647-06b4-42d5-9431-d31353e35b0c"),
                            RoleId = new Guid("43baf319-d42a-4abf-9af7-ba8e0cf12950")
                        },
                        new
                        {
                            UserId = new Guid("a5c9c789-54cf-4ca4-a274-1f3edd3b7c15"),
                            RoleId = new Guid("f6b8aa2a-096d-4f04-aa42-2f4ad123e7e0")
                        });
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArticleViewCount")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChangedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("643ed536-2402-44c4-866c-344c63a744e1"),
                            ArticleContent = "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.",
                            ArticleTitle = "Yapay Zekada Devrim",
                            ArticleViewCount = 15,
                            CategoryId = new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 5, 6, 15, 13, 2, 190, DateTimeKind.Local).AddTicks(8606),
                            ImageId = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            UserId = new Guid("c293c647-06b4-42d5-9431-d31353e35b0c"),
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("fc9a30ff-b571-4656-8c83-3f748465ff05"),
                            ArticleContent = "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.",
                            ArticleTitle = "Hava Durumlarını Makine Öğrenmesi ile Tahmin Etmek",
                            ArticleViewCount = 15,
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 5, 6, 15, 13, 2, 190, DateTimeKind.Local).AddTicks(8613),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            UserId = new Guid("a5c9c789-54cf-4ca4-a274-1f3edd3b7c15"),
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                            CategoryName = "ASP.NET Core",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 5, 6, 15, 13, 2, 190, DateTimeKind.Local).AddTicks(8836),
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            CategoryName = "Visual Studio 2022",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 5, 6, 15, 13, 2, 190, DateTimeKind.Local).AddTicks(8840),
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChangedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 5, 6, 15, 13, 2, 190, DateTimeKind.Local).AddTicks(8948),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 5, 6, 15, 13, 2, 190, DateTimeKind.Local).AddTicks(8951),
                            FileName = "images/vstest",
                            FileType = "png",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUser", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserClaim", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserLogin", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserRole", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCoreBlog.Entites.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUserToken", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.Article", b =>
                {
                    b.HasOne("MyCoreBlog.Entites.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCoreBlog.Entites.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("MyCoreBlog.Entites.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("MyCoreBlog.Entites.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}