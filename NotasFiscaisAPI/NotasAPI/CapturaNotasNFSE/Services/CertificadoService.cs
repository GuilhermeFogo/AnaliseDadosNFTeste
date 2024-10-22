using CapturaNotas.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapturaNotas.Services
{
    public class CertificadoService : ICertificadoService
    {
        public string Caminho { get; set; }
        public string Senha { get; set; }
        public CertificadoService(string Caminho, string senha) 
        {
            this.Caminho = Caminho;
            this.Senha = senha;
        }
        public X509Certificate2 GetCertificado()
        {
            return new X509Certificate2(Caminho, Senha);
        }
    }
}
