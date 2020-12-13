using Microsoft.EntityFrameworkCore;
using OnlineShop.Domain.Models;

namespace OnlineShop.Domain.Migrations
{
    public static class ModelBuilderExteention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var categories = new Category[]
            {
                new Category { Description = "Phones and accessories", Name = "Phones", Id = 0 },
                new Category { Description = "Computers and accessories", Name = "Computers", Id = 1 },
                new Category { Description = "Photo, video, audio and accessories", Name = "Media", Id = 2 },
                new Category { Description = "Consoles and accessories", Name = "Game Consoles", Id = 3 }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            var subCategories = new SubCategory[]
            {
                new SubCategory { Description = "Mobile phones", Name = "Mobile Phones", Id = 0, Category = categories[0]},
                new SubCategory { Description = "Mobile phones accessories", Name = "Accessories", Id = 1, Category = categories[0]},
                new SubCategory { Description = "Computers", Name = "Computers", Id = 2, Category = categories[1]},
                new SubCategory { Description = "Laptops", Name = "Laptops", Id = 3, Category = categories[1]},
                new SubCategory { Description = "Photo and мideo сameras", Name = "Сameras", Id = 4, Category = categories[2]},
                new SubCategory { Description = "Headphones", Name = "Headphones", Id = 5, Category = categories[2]},
                new SubCategory { Description = "Consoles", Name = "Consoles", Id = 6, Category = categories[2]},
                new SubCategory { Description = "Game console accessories", Name = "Accessories", Id = 6, Category = categories[3]},
            };

            modelBuilder.Entity<SubCategory>().HasData(subCategories);
        }
    }
}

