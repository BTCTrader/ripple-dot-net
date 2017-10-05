using System.Security.Cryptography;

namespace Ripple.Signing.Utils
{
    internal class HashUtils
    {
        public static byte[] PublicKeyHash(byte[] bytes)
        {
            var hash = SHA256.Create();
            var riper = HashAlgorithm.Create();
            bytes = hash.ComputeHash(bytes, 0, bytes.Length);
            return riper.ComputeHash(bytes, 0, bytes.Length);
        }
    }
}