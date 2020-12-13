using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Domain.Models
{
    public class Order
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }
        
        [StringLength(20)]
        public string LastNamee { get; set; }
        
        [StringLength(20)]
        public string Email { get; set; }
        
        [StringLength(20)]
        public string Phone { get; set; }
        
        [StringLength(20)]
        public string Country { get; set; }
        
        [StringLength(20)]
        public string City { get; set; }
        
        [StringLength(20)]
        public string Street { get; set; }
        
        public int Apartment { get; set; }
        
        public Product Product { get; set; }
    }
}
