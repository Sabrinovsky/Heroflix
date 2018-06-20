using Heroflix.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroflix.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime AssistidoEm { get; set; }
        public StatusFilme Status { get; set; }
        public String Genero { get; set; }
        public String Sinopse { get; set; }
        public String Elenco { get; set; }
    }
}
