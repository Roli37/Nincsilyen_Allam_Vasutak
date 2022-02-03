using System;
using System.Security.Cryptography;
using System.Text;

namespace VasuthalozatPublicApplication.Algorithms
{
    public class PasswordHash
    {
        public static string Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }
    }
}
