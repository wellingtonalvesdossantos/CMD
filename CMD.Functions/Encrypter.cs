using System;
using System.Linq;

namespace CMD.Functions
{
    public class Encrypter
    {
        public string Encrypt(string value)
        {
            return new string(value.Reverse().ToArray());
        }

        /*
        public string Decrypt(string value)
        {
            return new string(value.Reverse().ToArray());
        }
        */
    }
}
