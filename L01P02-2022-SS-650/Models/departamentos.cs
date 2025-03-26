using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_SS_650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 3)]
        public string departamento { get; set; }
    }
}
