using System.Text;
using System.Security.Cryptography;

namespace Accountant.Main
{
    internal class PasswordHash
    {
        public string Password;

        public string Hash (string P)
        {
            var Algoritm = new SHA256CryptoServiceProvider();
            var ByteValue = Encoding.UTF8.GetBytes (P);
            var Hash = Algoritm.ComputeHash (ByteValue);
            Password = Convert.ToBase64String(Hash);
            return Password;
        }
    }
}
