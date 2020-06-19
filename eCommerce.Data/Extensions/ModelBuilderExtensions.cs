using eCommerce.Data.Entities;
using eCommerce.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() {
                    Key = "HomeTitle",
                    Value = "This is home page of eCommerce"
                },
                new AppConfig() { 
                    Key = "HomeKeyword",
                    Value = "This is keyword of eCommerce"
                },
                new AppConfig() {
                    Key = "HomeDescription",
                    Value = "This is description of eCommerce"
                }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() {
                    Id = "vi-VN",
                    Name = "Tiếng Việt", IsDefault = true
                },
                new Language() {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category() {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category() {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                }
            );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new CategoryTranslation() {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men"
                },
                new CategoryTranslation() {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang women"
                },
                new CategoryTranslation() {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt products for women",
                    SeoTitle = "The shirt products for women"
                }
            );

           modelBuilder.Entity<Product>().HasData(
               new Product(){
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               }
            );

           modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                    Details = "Áo sơ mi nam trắng Việt Tiến",
                    Description = "Áo sơ mi nam trắng Việt Tiến"
                },
                new ProductTranslation(){
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viet-tien-men-t-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt"
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 3, CategoryId = 2 }
            );


            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var roleId1 = new Guid("98D30750-FFE1-4D9C-9DFE-05F0C5D64A0F");
            
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "employee",
                NormalizedName = "employee",
                Description = "Employee role"
            });
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId1,
                Name = "customer",
                NormalizedName = "customer",
                Description = "Customer role"
            });

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tedu.international@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Toan",
                LastName = "Bach",
                Dob = new DateTime(2020, 01, 31)
            });


            var adminId10 = new Guid("D2AC625B-FA25-4C71-B176-08D812C371E3");
            var adminId9 = new Guid("431C8EA6-D8EF-45D6-B175-08D812C371E3");
            var adminId8 = new Guid("4C3F8DE1-AE9B-4499-B174-08D812C371E3");
            var adminId7 = new Guid("C96C4420-5398-438D-B173-08D812C371E3");
            var adminId6 = new Guid("8F6E6938-2C2B-4075-B172-08D812C371E3");
            var adminId5 = new Guid("EE2FEBEF-2B6F-4860-B171-08D812C371E3");
            var adminId4 = new Guid("A21F1CE7-F421-46D4-B170-08D812C371E3");
            var adminId3 = new Guid("2892904E-4BB4-4AB0-B16F-08D812C371E3");
            var adminId2 = new Guid("3185E3E5-B1EE-4205-02A4-08D8127567CD");
            var adminId1 = new Guid("5DFD7DB6-11D3-43DD-DA0F-08D811B6ED1F");
            
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId1
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId2
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId3
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId4
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId5
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId1,
                UserId = adminId6
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId1,
                UserId = adminId7
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId1,
                UserId = adminId8
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId1,
                UserId = adminId9
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId1,
                UserId = adminId10
            });






        }
    }
}