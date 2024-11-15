using CapturaNotas.Modal;
using CapturaNotas.Services;
using NotaFiscalSP;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace CapturaNotas
{
    public class CapturaNFSEService : IServicoInternoCapturaNFSE
    {
        public void CapturarNotaNFSE()
        {
            string caminhoteste = "C:\\Users\\Guilherme\\Desktop\\MeuTreinamento\\AnaliseDados\\AnaliseDadosNFTeste\\NotasFiscaisAPI\\NotasAPI\\CapturaNotasNFSE\\ArquivosXSD\\schemasv02\\nfse\\PedidoConsultaNFePeriodo_v01.xml";
            string caminhocert = "";
            string senha = "Senha";
            ICertificadoService cert = new CertificadoService(caminhocert, senha);
            //cert.GetCertificado();

            var dados_pedidos =this.DesserializarDeXML<PedidoConsultaNFePeriodo>(caminhoteste);

            
            dados_pedidos.Cabecalho.CPFCNPJ.Item = new tpCPFCNPJ().Item = "";
            dados_pedidos.Cabecalho.NumeroPagina = 1;
            dados_pedidos.Cabecalho.CPFCNPJRemetente.Item = "";
            dados_pedidos.Cabecalho.dtInicio = DateTime.Today ;
            dados_pedidos.Cabecalho.dtFim = DateTime.Today.AddDays(15);
            dados_pedidos.Cabecalho.Inscricao = 0;
            dados_pedidos.Cabecalho.InscricaoSpecified = true;
            dados_pedidos.Cabecalho.Versao = 4;
            
            var assinaturaPrivada = cert.GetCertificado().GetRSAPrivateKey();
            var assinaturapublica =  cert.GetCertificado().GetRSAPublicKey();

            // verificar assinatura do xml
            


            ConsultaNFeRequest consultaNFeRequest = new ConsultaNFeRequest();
            consultaNFeRequest.VersaoSchema = 2;
            consultaNFeRequest.MensagemXML = "";
            ConsultaNFeResponse consultaNFeResponse = new ConsultaNFeResponse();




        }

        public T DesserializarDeXML<T>(string caminhoArquivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
