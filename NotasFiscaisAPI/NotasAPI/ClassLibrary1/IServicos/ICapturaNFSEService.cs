using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doman.IServicos
{
    public interface ICapturaNFSEService
    {

        public void CapturarNotaNFSE(string caminhocert, string senhacert, string CPFCNPJ,
            string CNPJPrestador, DateTime inicio, DateTime fim, int inscricaomunicipal);
    }
}
