using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace OnvifStandard.Common
{
    [XmlRoot(ElementName = "Security",
             Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public class SoapSecurityHeader
    {
        [XmlAttribute(AttributeName = "mustUnderstand",
                      Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public string MustUnderstand { get; set; } = "1";

        [XmlElement(ElementName = "UsernameToken",
                    Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public UsernameToken UsernameToken { get; set; }

        public static SoapSecurityHeader Create(string username, string password)
        {
            UsernameToken token = UsernameToken.Create(username, password);
            return new SoapSecurityHeader
            {
                UsernameToken = token
            };
        }
    }

    public class PasswordElement
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
    public class NonceElement
    {
        [XmlAttribute(AttributeName = "EncodingType")]
        public string EncodingType { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class UsernameToken
    {
        [XmlElement(Order = 0, ElementName = "Username",
                    Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public string Username { get; set; }

        [XmlElement(Order = 1, ElementName = "Password",
                    Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public PasswordElement Password { get; set; }

        [XmlElement(Order = 2, ElementName = "Nonce",
                    Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public NonceElement Nonce { get; set; }

        [XmlElement(Order = 3, ElementName = "Created",
                    Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd")]
        public string Created { get; set; }

        public static UsernameToken Create(string username, string password)
        {
            byte[] nonceBytes = new byte[16];
            RandomNumberGenerator.Create().GetBytes(nonceBytes);

            string created = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

            // PasswordDigest = Base64( SHA1( nonceBytes + created + password ) )
            byte[] createdBytes = Encoding.UTF8.GetBytes(created);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] combined = Combine(nonceBytes, createdBytes, passwordBytes);

            byte[] sha1 = SHA1.Create().ComputeHash(combined);
            string passwordDigest = Convert.ToBase64String(sha1);

            return new UsernameToken
            {
                Username = username,
                Nonce = new NonceElement
                {
                    EncodingType = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary",
                    Value = Convert.ToBase64String(nonceBytes)
                },
                Created = created,
                Password = new PasswordElement
                {
                    Type = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordDigest",
                    Value = passwordDigest
                }
            };
        }

        private static byte[] Combine(params byte[][] arrays)
        {
            int length = 0;
            foreach (byte[] a in arrays)
            {
                length += a.Length;
            }

            byte[] result = new byte[length];
            int offset = 0;

            foreach (byte[] a in arrays)
            {
                Buffer.BlockCopy(a, 0, result, offset, a.Length);
                offset += a.Length;
            }

            return result;
        }
    }
}