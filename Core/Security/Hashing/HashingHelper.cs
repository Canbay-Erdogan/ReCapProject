using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            VerifyPasswordHash(password, passwordHash, passwordSalt);
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var ComputedHas = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < ComputedHas.Length; i++)
                {
                    if (ComputedHas[i] != passwordHash[i])
                        return false;
                }
                return true;
            }
        }
    }
}
