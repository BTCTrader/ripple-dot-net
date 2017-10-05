using SshNet.Security.Cryptography;
using SHA256 = System.Security.Cryptography.SHA256;

namespace Ripple.Signing.Utils
{
    internal class HashUtils
    {
        public static byte[] PublicKeyHash(byte[] bytes)
        {
            var hash = SHA256.Create();
            var riper = new RIPEMD160();
            bytes = hash.ComputeHash(bytes, 0, bytes.Length);
            return riper.ComputeHash(bytes, 0, bytes.Length);
        }
    }
}