using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaNotas.Modal
{
    public interface IServicoInternoCapturaNFSE
    {
        public void CapturarNotaNFSE(string caminhocert, string senhacert, string CPFCNPJ,
            string CNPJPrestador, DateTime inicio, DateTime fim, int inscricaomunicipal);
    }
}
