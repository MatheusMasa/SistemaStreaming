using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class Produtor : Artista
    {
        public List<Filme> Filmes { get; set; }
    }
}
