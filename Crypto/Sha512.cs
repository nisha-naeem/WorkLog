using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class Sha512
    {
        // These constants may be changed without breaking existing hashes.
        const int SALT_BYTES = 24;    // setting the size of the arrays
        private const char DELIMITER = ':';

        // These constants define the encoding and may not be changed.
        const int HASH_SECTIONS = 4;
        const int HASH_ALGORITHM_INDEX = 0;
        const int HASH_SIZE_INDEX = 1;
        const int SALT_INDEX = 2;
        const int HASH_INDEX = 3;

        public static string CreateHashSHA512(string PasswordString)
        {

            // TO STORE A PASSWORD

            // 1) Generate a long random salt using a CSPRNG(Cryptographically Secure Pseudo-Random Number Generator). 
            // .NET does this using System.Security.Cryptography.RNGCryptoServiceProvider
            string authenticationHash;
            byte[] Salt = new byte[25];
            string SaltString;

            try
            {
                using (RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider())
                {
                    // generates a cryptographically secure salt consisting of an array of bytes having the amount of bytes specified by the constant SALT_BYTES
                    csprng.GetBytes(Salt);
                    SaltString = Convert.ToBase64String(Salt);
                }
            }

            // MsgBox(SaltString)

            catch (CryptographicException ex)
            {
                throw new CryptographicException("Random number generator not available.");
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Invalid argument given to random number generator.");
            }


            // 2) Prepend the salt to the password and hash it with a standard cryptographic hash function such as SHA256.
            // if "aaaa" is the salt(generated using CSPRNG) and "bbbb" is the password. The String to be Hashed would be "aaaabbbb"
            // "aaaabbbb" would then be UTF8 encoded and assigned to an array as a collection of bytes using something like below.

            // Dim SaltPasswordString As String  = aaaabbbb
            // Dim SaltPasswordByteArray() As Byte = Encoding.UTF8.GetBytes(SaltPasswordString)

            string saltStringNPasswordString = SaltString + PasswordString;  // Combinig SaltString and PasswordString
            byte[] saltedPasswordByteArray = Encoding.UTF8.GetBytes(saltStringNPasswordString); // This step converts the combination of SaltString and PasswordString given to the funtion into a collection of bytes.
            byte[] saltedSha512PasswordHash; // Declaring the array to hold salted and hashed password as an array of bytes prior to conversion to base64string. 

            // 3) Save both the salt and the hash in the user's database record.

            // hash would be stored as 
            // algorithm:HashByteSize:salt:hash
            // SHA512:88:aaaa:tn+Zr/xo99LI+kSwLOUav72X

            // if the algorithm is updated at a later date. Storing the algorithm name with the hash keeps already existing Passes operational, since they will be processed using
            // the old algorithm. only new and changed passes will use the updated algorithm.
            string saltedSha512PasswordHashString;
            try
            {
                using (SHA512Managed SHA512Algorithm = new SHA512Managed())
                {
                    saltedSha512PasswordHash = SHA512Algorithm.ComputeHash(saltedPasswordByteArray);
                    saltedSha512PasswordHashString = Convert.ToBase64String(saltedSha512PasswordHash);
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Cannot compute hash!");
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException("Cannot return calculated Hash");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            // HashFormat: algorithm:hashSize:salt:hash
            authenticationHash = string.Format("SHA512:{0}:{1}:{2}", saltedSha512PasswordHashString.Length, SaltString, saltedSha512PasswordHashString);
            return authenticationHash;
        }
        public static bool VerifyPassword(string password, string goodHash)
        {

            // TO VALIDATE THE PASSWORD

            // Retrieve the user's salt and hash from the database.
            string[] splittedHash = goodHash.Split(DELIMITER);

            // Verifying that the splittedHash has 3 parts where 0 is algorithm, 1 is hash size, 2 is the salt and 3 is the hash.
            // splittedHash.Length property returns 1 value more than the last array index. Since Length starts counter from 1 which array couunter starts at Zero
            // This requires HASH_SECTIONS to be set as 4 while array has a max index of 3
            if (splittedHash.Length != HASH_SECTIONS)
            {
                throw new Exception("Fields are missing from the password hash.");
            }

            // Only SHA512 is supported right now
            if (splittedHash[HASH_ALGORITHM_INDEX] != "SHA512")
            {
                throw new Exception("Unsupported hash type");
            }

            // Verify that the Hash is valid.
            if (splittedHash[HASH_INDEX].Length != int.Parse(splittedHash[HASH_SIZE_INDEX]))
            {
                throw new Exception("Invalid hash. Hash length doesn't match stored hash length.");
            }

            // Get the salt, Prepend the salt to the given password and hash it using the same hash function.
            string gettingSaltString = splittedHash[SALT_INDEX];
            string prependAquiredSaltNPassword = gettingSaltString + password;
            byte[] AquiredSaltNPasswordByteArray = Encoding.UTF8.GetBytes(prependAquiredSaltNPassword);
            byte[] SHA512AquiredSaltNPasswordHash;
            // Compare the hash of the given password with the hash from the database. If they match, the password is correct. Otherwise, the password is incorrect.

            string Sha512AquiredPasswordHashString;
            try
            {
                using (SHA512Managed SHA512Algorithm = new SHA512Managed())
                {
                    SHA512AquiredSaltNPasswordHash = SHA512Algorithm.ComputeHash(AquiredSaltNPasswordByteArray);
                    Sha512AquiredPasswordHashString = Convert.ToBase64String(SHA512AquiredSaltNPasswordHash);
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("Cannot compute hash!");
            }
            catch (ObjectDisposedException ex)
            {
                throw new ObjectDisposedException("Cannot return calculated Hash");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            string hashForComparisionWithGoodHash = string.Format("SHA512:{0}:{1}:{2}", Sha512AquiredPasswordHashString.Length, gettingSaltString, Sha512AquiredPasswordHashString);

            if (hashForComparisionWithGoodHash == goodHash)
                return true;
            else
                return false;
        }
    }
}
