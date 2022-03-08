using System.ComponentModel.DataAnnotations;

namespace TaskClient.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; }
        [Display(Name="Phone Number")]
        [Required(ErrorMessage = "Phone number required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "CUIT required")]
        public string CUIT { get; set; }
    }
}
