using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Album
    {
        [Required]
        public string Title { get; set; }

    }
}
