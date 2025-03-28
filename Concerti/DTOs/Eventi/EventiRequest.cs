using System.ComponentModel.DataAnnotations;

namespace Concerti.DTOs.Eventi
{
    public class EventiRequest
    {
        [Required]
        public string Titolo { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public string Luogo { get; set; }

    }
}
