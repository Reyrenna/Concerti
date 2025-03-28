using System.ComponentModel.DataAnnotations;

namespace Concerti.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        public ICollection<Biglietto> Bigliettos { get; set; }
    }
}
