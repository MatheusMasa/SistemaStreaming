using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public class Produtor : Artista
    {
        public Produtor(int id, string nome, string bio, string fotoPerfilURL) : base(id, nome, bio, fotoPerfilURL)
        {
        }

        public List<Filme> Filmes { get; set; }
    }
}
