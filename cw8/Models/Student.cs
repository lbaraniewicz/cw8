using System.ComponentModel.DataAnnotations;

namespace cw8.Models
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        [MaxLength(200)]
        public string Imie { get; set; }
        [MaxLength(200)]
        public string Nazwisko { get; set; }
        [MaxLength(100)]
        public string NrIndeksu { get; set; }

        public int RokStudiow { get; set; }

        public virtual ICollection<Studia> IdStudiaNavigation { get; set; }

    }
}
