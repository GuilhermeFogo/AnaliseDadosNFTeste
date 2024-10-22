using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doman.Modal
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public string Email { get; set; }
        public Usuario(string Nome, string Senha, string Email)
        {
            this.Nome = Nome;
            this.Senha = Senha;
            this.Email = Email;
        }
    }
}
