using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}
