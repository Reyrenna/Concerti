using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concerti.Models
{
    public class Biglietto
    {
        [Key]
        public int IdBiglietto { get; set; }
        [ForeignKey("IdEvento")]
        public int IdEvento { get; set; }
        [ForeignKey("IdUser")]
        public int IdUser { get; set; }

        public DateTime DataAcquisto { get; set; }
    }
}
