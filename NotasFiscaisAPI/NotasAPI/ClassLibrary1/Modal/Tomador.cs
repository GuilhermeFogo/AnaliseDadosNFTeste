using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doman.Modal
{
    public class Tomador
    {
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string UF { get; set; }
        public string Municipio { get; set; }
        public string Endereco { get; set; }

        public Tomador(string NomeEmpresa, string CNPJ, string CPF, string IM, string UF, string Municipio,
            string EnderecoNota)
        {
            this.CNPJ = CNPJ;
            this.CPF = CPF;
            this.NomeEmpresa = NomeEmpresa;
            this.Endereco = EnderecoNota;
            this.UF = UF;
            this.InscricaoMunicipal = IM;
            this.Municipio = Municipio;
        }
        public Tomador()
        {
            
        }

    }
}
