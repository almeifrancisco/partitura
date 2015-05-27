using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Service.service.seguranca
{
    public class HashComputer
    {
         public string GetPasswordHashAndSalt(string message)
        {
            // Let us use SHA256 algorithm to 
            // generate the hash from this salted password
            UnicodeEncoding ue = new UnicodeEncoding();
            SHA256 sha = new SHA256Managed();
            byte[] dataBytes = ue.GetBytes(message);
            byte[] resultBytes = sha.ComputeHash(dataBytes);
            string str = "";
             foreach(byte b in resultBytes)
             {
                 str += string.Format("{0:x2}", b);
             }
            // return the hash string to the caller
             return str;
        }
    }
}
