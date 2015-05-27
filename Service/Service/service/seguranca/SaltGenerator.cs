using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Service.service.seguranca
{
    public class SaltGenerator
    {
        private RNGCryptoServiceProvider m_cryptoServiceProvider = null;
        private const int SALT_SIZE = 24;

        public SaltGenerator()
        {
            m_cryptoServiceProvider = new RNGCryptoServiceProvider();
        }

        public  string GetSaltString()
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            // Lets create a byte array to store the salt bytes
            byte[] saltBytes = new byte[SALT_SIZE];

            // lets generate the salt in the byte array
            m_cryptoServiceProvider.GetNonZeroBytes(saltBytes);

            // Let us get some string representation for this salt
            string saltString="";
            foreach (byte b in saltBytes)
            {
                saltString += string.Format("{0:x2}", b);
            }
            // Now we have our salt string ready lets return it to the caller
            return saltString;
        }       
    }
}
