using IngressoMVC.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaStreaming.Models
{
    public abstract class Artista : IEntidade
    {
        protected Artista(int id, string nome, string bio, string fotoPerfilURL)
        {
            this.Id = id;
            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;
            Nome = nome;
            Bio = bio;
            FotoPerfilURL = fotoPerfilURL;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Nome { get; private set; }
        public string Bio { get; private set; }
        public string FotoPerfilURL { get; private set; }
    }
}
