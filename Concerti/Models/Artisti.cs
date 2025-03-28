using System.ComponentModel.DataAnnotations;

namespace Concerti.Models
{
    public class Artisti
    {
        [Key]
        public int IdArtista { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Genere { get; set; }

        [Required]
        [StringLength(300)]
        public string Descrizione { get; set; }

       public ICollection<Evento> eventos { get; set; }
    }
}
