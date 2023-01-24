using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw8.Models
{
    public class Studia
    {
        [Key]
        public int IdStudia { get; set; }
        [MaxLength(200)]
        public string Nazwa { get; set; }
        [MaxLength(200)]
        public string Tryb { get; set; }

        public int IdStudent { get; set; }
        [ForeignKey("IdStudent")]
        public virtual Student Student { get; set; }
    }
}
