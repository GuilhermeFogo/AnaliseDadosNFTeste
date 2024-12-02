using CapturaNotas;
using CapturaNotas.Modal;
using Doman.IServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CapturaNotasNFSEService : ICapturaNFSEService
    {
        private IServicoInternoCapturaNFSE servicoInternoCapturaNFSE;
        public CapturaNotasNFSEService(IServicoInternoCapturaNFSE servicoInternoCapturaNFSE)
        {
            this.servicoInternoCapturaNFSE = servicoInternoCapturaNFSE;
        }

        public void CapturarNotaNFSE(string caminhocert, string senhacert, string CPFCNPJ, string CNPJPrestador, DateTime inicio, DateTime fim, int inscricaomunicipal)
        {
            this.servicoInternoCapturaNFSE.CapturarNotaNFSE(caminhocert, senhacert, CPFCNPJ, CNPJPrestador,
                inicio, fim, inscricaomunicipal);
        }
    }
}
