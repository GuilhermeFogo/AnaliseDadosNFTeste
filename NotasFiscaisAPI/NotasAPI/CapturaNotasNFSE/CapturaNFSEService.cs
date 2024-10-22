using CapturaNotas.Modal;
using CapturaNotas.Services;

namespace CapturaNotas
{
    public class CapturaNFSEService : IServicoInternoCapturaNFSE
    {
        public void CapturarNotaNFSE()
        {
           var caminhorequest = File.ReadAllText("C:\\Users\\Guilherme\\Desktop\\MeuTreinamento\\AnaliseDados\\AnaliseDadosNFTeste\\NotasFiscaisAPI\\NotasAPI\\CapturaNotasNFSE\\ArquivosXSD\\schemasv02\\nfse\\PedidoConsultaNFePeriodo_v01.xsd");
           string caminho = "";
           string senha = "Senha";
           ICertificadoService cert = new CertificadoService(caminho, senha);
           cert.GetCertificado();
        }
    }
}
