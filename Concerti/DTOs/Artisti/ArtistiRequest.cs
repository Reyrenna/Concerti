using System.ComponentModel.DataAnnotations;

namespace Concerti.DTOs.Artisti
{
    public class ArtistiRequest
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Genere { get; set; }
        [Required]
        public string Descrizione { get; set; }
    }
}
