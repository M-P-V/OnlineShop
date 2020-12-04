using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Domain.Models
{
    public class Adress
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string Country { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(20)]
        public string Street { get; set; }
        public int Apartment{ get; set; }
    }
}
