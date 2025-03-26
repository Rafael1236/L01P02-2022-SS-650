using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_SS_650.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string materia { get; set; }
        [Range(1, 10, ErrorMessage ="Se permite hasta un maximo de 10 unidades valorativas")]
        public int unidades_valorativas { get; set; }
        [Required]
        [RegularExpression("[AIZ]", ErrorMessage = "Solo se permiten los estados 'A', 'I' o 'Z'.")]
        public string estado { get; set; }
    }
}
