using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        // verdigimiz bir passwordun hash ini olusturur
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (HMACSHA512 hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        // verdigimiz bir passwordun hashini olusturp veritabanındaki hash ile karsılastiriyor
        // parametre olarak veritabanındaki hashi ve salt i veriyoruz

        // hash bir sifre sifrelenir diyelim
        // salt ile bu haslenmis sifre biraz daha guclendirilir 
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) // sifre dogrulama
        {
            using (HMACSHA512 hmac = new HMACSHA512(passwordSalt))
            {

                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if(computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
