using System.ComponentModel.DataAnnotations;

namespace L01P02_2022_SS_650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        [Required] 
        [StringLength(100, MinimumLength = 3)]
        public string facultad { get; set; }
    }
}
