using System.Security.Cryptography;
using System.Text;

namespace Panosen.Hash
{
    /// <summary>
    /// Signature helper class.
    /// </summary>
    public class HashHelper
    {
        /// <summary>
        /// Sha256Hex
        /// </summary>
        public static string Sha256Hex(string text, Encoding encoding = default)
        {
            var bytes = (encoding ?? Encoding.UTF8).GetBytes(text);

            return Sha256Hex(bytes);
        }

        /// <summary>
        /// Sha256Hex
        /// </summary>
        public static string Sha256Hex(byte[] bytes)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashbytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashbytes.Length; i++)
                {
                    builder.Append(hashbytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// HmacSha256
        /// </summary>
        public static byte[] HmacSha256(byte[] key, byte[] msg)
        {
            using (HMACSHA256 hMACSHA256 = new HMACSHA256(key))
            {
                return hMACSHA256.ComputeHash(msg);
            }
        }
    }
}
