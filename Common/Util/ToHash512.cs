using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Util
{
    public class ToHash512
    {
        public string genHash512(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            System.Security.Cryptography.SHA512Managed sha512HashString = new System.Security.Cryptography.SHA512Managed();

            byte[] hash = sha512HashString.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }

            return hashString;
        }
    }
}
