using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaNotas.Modal
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Security.Cryptography.X509Certificates;
    using System.Security.Cryptography.Xml;

    [XmlRoot(ElementName = "PedidoConsultaNFePeriodo", Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoConsultaNFePeriodo
    {
        [XmlElement(ElementName = "Cabecalho")]
        public Cabecalho Cabecalho { get; set; }

        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }

        public PedidoConsultaNFePeriodo()
        {
            Cabecalho = new Cabecalho();
        }

        public string GerarXML()
        {
            var xmlSerializer = new XmlSerializer(typeof(PedidoConsultaNFePeriodo));
            using (var stringWriter = new System.IO.StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, this);
                return stringWriter.ToString();
            }
        }

        public void AssinarXML(string xmlPath, X509Certificate2 certificado)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(xmlPath);

            SignedXml signedXml = new SignedXml(xmlDoc);
            signedXml.SigningKey = certificado.PrivateKey;

            Reference reference = new Reference();
            reference.Uri = "";

            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);
            signedXml.AddReference(reference);

            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(certificado));
            signedXml.KeyInfo = keyInfo;

            signedXml.ComputeSignature();

            XmlElement xmlDigitalSignature = signedXml.GetXml();
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

            xmlDoc.Save(xmlPath);
        }
    }

    public class Cabecalho
    {
        [XmlElement(ElementName = "CPFCNPJRemetente")]
        public CPFCNPJ CPFCNPJRemetente { get; set; }

        [XmlElement(ElementName = "CPFCNPJ")]
        public CPFCNPJ CPFCNPJ { get; set; }

        [XmlElement(ElementName = "Inscricao", IsNullable = true)]
        public string Inscricao { get; set; }

        [XmlElement(ElementName = "dtInicio")]
        public DateTime dtInicio { get; set; }

        [XmlElement(ElementName = "dtFim")]
        public DateTime dtFim { get; set; }

        [XmlElement(ElementName = "NumeroPagina")]
        public int NumeroPagina { get; set; }

        [XmlAttribute(AttributeName = "Versao")]
        public string Versao { get; set; } = "1";

        public Cabecalho()
        {
            CPFCNPJRemetente = new CPFCNPJ();
            CPFCNPJ = new CPFCNPJ();
        }
    }

    public class CPFCNPJ
    {
        [XmlElement(ElementName = "Cnpj", IsNullable = true)]
        public string Cnpj { get; set; }

        [XmlElement(ElementName = "Cpf", IsNullable = true)]
        public string Cpf { get; set; }
    }

}
