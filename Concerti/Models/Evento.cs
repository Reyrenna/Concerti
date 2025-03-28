using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concerti.Models
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        [Required]
        public string Titolo { get; set; }
        
        public DateTime Data { get; set; }
        [Required]
        public string Luogo { get; set; }

        [ForeignKey("IdArtista")]
        public int IdArtista { get; set; }

        public ICollection<Biglietto> Bigliettos { get; set; }
    }
}
