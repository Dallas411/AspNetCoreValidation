using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreValidation.Models
{
    public class IndexViewModel
    {
        [Required(ErrorMessage = "Il Nome è obbligatorio")]
        [StringLength(5,ErrorMessage ="Lunghezza massima 5 caratteri")]
        public string Name { get; set; }
        [RegularExpression(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$", ErrorMessage = "Formato gg/MM/yyyy")]
        public string DoB { get; set; }
    }
}
