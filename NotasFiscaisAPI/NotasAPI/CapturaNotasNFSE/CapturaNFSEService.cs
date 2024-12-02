using CapturaNotas.Modal;
using CapturaNotas.Services;
using NotaFiscalSP;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CapturaNotas
{
    public class CapturaNFSEService : IServicoInternoCapturaNFSE
    {
        public void CapturarNotaNFSE(string caminhocert, string senhacert, string CPFCNPJ,
            string CNPJPrestador, DateTime inicio, DateTime fim, int inscricaomunicipal)
        {
            // Caminhos para arquivos e senha do certificado
            //string caminhoteste = "C:\\Users\\Guilherme\\Desktop\\MeuTreinamento\\AnaliseDados\\AnaliseDadosNFTeste\\NotasFiscaisAPI\\NotasAPI\\CapturaNotasNFSE\\ArquivosXSD\\schemasv02\\nfse\\PedidoConsultaNFePeriodo_v01.xml";
            
            // Carregar o certificado digital
            ICertificadoService cert = new CertificadoService(caminhocert, senhacert);
            var certificado = cert.GetCertificado();

            // Desserializar o XML para o objeto PedidoConsultaNFePeriodo
            var dados_pedidos =  new PedidoConsultaNFePeriodo();

            //PedidoConsultaNFePeriodo pedidoConsultaNFePeriodo = new PedidoConsultaNFePeriodo();
            // Preenchimento dos campos necessários
            dados_pedidos.Cabecalho.CPFCNPJ.Item = CPFCNPJ;
            dados_pedidos.Cabecalho.NumeroPagina = 1;
            dados_pedidos.Cabecalho.CPFCNPJRemetente.Item = CNPJPrestador;
            dados_pedidos.Cabecalho.dtInicio = inicio;
            dados_pedidos.Cabecalho.dtFim = fim;
            dados_pedidos.Cabecalho.Inscricao = inscricaomunicipal;
            dados_pedidos.Cabecalho.InscricaoSpecified = true;
            dados_pedidos.Cabecalho.Versao = 4;

            // Criar a assinatura digital correta usando a chave privada
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.PreserveWhitespace = true;
            using (StringWriter stringWriter = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PedidoConsultaNFePeriodo));
                serializer.Serialize(stringWriter, dados_pedidos);
                documentoXml.LoadXml(stringWriter.ToString());
            }

            // Assinar o XML
            AssinarXml(documentoXml, certificado);

            // Atribuir a assinatura ao SignatureType no objeto dados_pedidos
            dados_pedidos.Signature = new SignatureType
            {
                SignatureValue = new SignatureValueType
                {
                    Value = Encoding.UTF8.GetBytes(documentoXml.OuterXml)
                }
            };

            // Crie o request para a consulta
            ConsultaNFeRequest consultaNFeRequest = new ConsultaNFeRequest
            {
                VersaoSchema = 2,
                MensagemXML = documentoXml.OuterXml
            };

            ConsultaNFeResponse consultaNFeResponse = new ConsultaNFeResponse();
            // Aqui você fará a requisição ao web service usando o XML assinado.
        }

        public T DesserializarDeXML<T>(string caminhoArquivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        private void AssinarXml(XmlDocument xmlDoc, X509Certificate2 certificado)
        {
            // Cria o objeto SignedXml
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Define a chave privada do certificado
            signedXml.SigningKey = certificado.GetRSAPrivateKey();

            // Configura o método de canonicalização e algoritmo de assinatura
            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigCanonicalizationUrl;
            signedXml.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA256Url;

            // Cria uma referência ao documento a ser assinado
            Reference referencia = new Reference();
            referencia.Uri = "";

            // Adiciona métodos de transformação necessários
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            referencia.AddTransform(env);

            // Define o algoritmo de hash
            referencia.DigestMethod = SignedXml.XmlDsigSHA256Url;

            // Adiciona a referência ao SignedInfo
            signedXml.AddReference(referencia);

            // Adiciona informações do certificado ao KeyInfo
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(certificado));
            signedXml.KeyInfo = keyInfo;

            // Gera a assinatura
            signedXml.ComputeSignature();

            // Converte a assinatura para Base64
            byte[] assinaturaBytes = signedXml.Signature.SignatureValue;
            string assinaturaBase64 = Convert.ToBase64String(assinaturaBytes);
            
            // Adiciona a assinatura ao documento XML
            XmlElement signatureElement = signedXml.GetXml();
            
            XmlNamespaceManager nsManager = new XmlNamespaceManager(signatureElement.OwnerDocument.NameTable);
            nsManager.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");
            XmlNode signatureValueNode = signatureElement.SelectSingleNode("//ds:SignatureValue", nsManager);
            if (signatureValueNode != null)
            {
                signatureValueNode.InnerText = assinaturaBase64;
            }
            else
            {
                throw new Exception("Nó 'SignatureValue' não encontrado.");
            }
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(signatureElement, true));
        }
    }
}