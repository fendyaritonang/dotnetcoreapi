using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandCreateDto
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
