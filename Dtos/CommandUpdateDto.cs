using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        [Column(TypeName = "varchar(MAX)")]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(4000)]
        public string Line { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Platform { get; set; }
    }
}
