using Infra.Entidade.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infra.Endidade
{
    public class NotasFiscais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_nota { get; set; }
        public string NumeroNota { get; set; }
        public string NomeEmpresa_Prestador { get; set; }
        public string CNPJ_Prestador { get; set; }
        public string CPF_Prestador { get; set; }
        public string InscricaoMunicipal_Prestador { get; set; }
        public string UF_Prestador { get; set; }
        public string Municipio_Prestador { get; set; }
        public string Endereco_Prestador { get; set; }
        public string NomeEmpresa_Tomador { get; set; }
        public string CNPJ_Tomador { get; set; }
        public string CPF_Tomador { get; set; }
        public string InscricaoMunicipal_Tomador { get; set; }
        public string UF_Tomador { get; set; }
        public string Municipio_Tomador { get; set; }
        public string Endereco_Tomador { get; set; }
        public string ValorNota { get; set; }
        public ModeloNota tipo_nota { get; set; }


    }
}
