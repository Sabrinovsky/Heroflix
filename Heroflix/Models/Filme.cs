using Heroflix.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Heroflix.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        [MaxLength(5, ErrorMessage ="Achou errado otário")]
        public string Titulo { get; set; }

        [Display(Name = "Assistido em")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime AssistidoEm { get; set; }

  
        public StatusFilme Status { get; set; }

        public String Genero { get; set; }

        public String Sinopse { get; set; }

        public String Elenco { get; set; }

        public String UrlCapa { get; set; }


    }
}
