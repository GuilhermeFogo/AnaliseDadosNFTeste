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
        public string Role { get; set; }
        public string Email { get; set; }
        public bool Ativado { get; set; }
        public bool Resetsenha { get; set; }
        public string CodigoResgate { get; set; }
        public Usuario(string Nome, string Senha, string Email, bool ativado, bool resetsenha,
            string codresgate, string role)
        {
            this.Nome = Nome;
            this.Senha = Senha;
            this.Email = Email;
            this.Ativado = ativado;
            this.Resetsenha = resetsenha;
            this.CodigoResgate = codresgate;
            this.Role = role;
        }

        public Usuario()
        {
            
        }
    }
}
