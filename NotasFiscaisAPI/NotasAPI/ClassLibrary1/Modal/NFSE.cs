using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doman.Modal
{
    public class NFSE
    {
        public string NumeroNota { get; set; }
        public DateTime DataNota { get; set; }
        public string CodigoValidacao { get; set; }
        public Prestador Prestador { get; set; }
        public Tomador Tomador { get; set; }

        public string ValorNota { get; set; }
        
        public NFSE()
        {
            this.Prestador = new Prestador();
            this.Tomador = new Tomador();
        }


        public NFSE(string numeroNota, DateTime dataNota, string codigoValidacao, Prestador prestador, Tomador tomador, string valorNota)
        {
            NumeroNota = numeroNota ?? throw new ArgumentNullException(nameof(numeroNota));
            DataNota = dataNota;
            CodigoValidacao = codigoValidacao ?? throw new ArgumentNullException(nameof(codigoValidacao));
            Prestador = prestador ?? throw new ArgumentNullException(nameof(prestador));
            Tomador = tomador ?? throw new ArgumentNullException(nameof(tomador));
            ValorNota = valorNota ?? throw new ArgumentNullException(nameof(valorNota));
        }
    }
}
