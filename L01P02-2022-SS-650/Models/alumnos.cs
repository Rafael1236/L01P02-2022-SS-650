using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_SS_650.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(10)]
        public string codigo { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string nombre { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string apellidos { get; set; }
        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Formato de DUI inválido (Ej: 12345678).")]
        public int dui { get; set; } // Cambiado de StringLength a Range
        [Range(0, 1)]
        public int estado { get; set; }
    }
}
