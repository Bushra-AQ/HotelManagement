using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Mobile_No { get; set; }
}
}
