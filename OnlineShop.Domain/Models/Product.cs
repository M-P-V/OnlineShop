using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Domain.Models
{
    public class Product
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public Category Category { get; set; }

        public DbSet<AttributeValue> AttributeValues { get; set; }
    }
}
