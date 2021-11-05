using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Filmes_CS.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required]
        public string Diretor { get; set; }
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve estar entre 1 e 600 minutos")]
        public string Duracao { get; set; }
        
    }
}
