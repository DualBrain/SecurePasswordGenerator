using System;
using System.Text;

namespace SecurePasswordGenerator
{
    /// <summary>
    /// Class to generate random passwords.
    /// </summary>
    public class PasswordClass
    {

        public static bool useLower;
        public static bool useUpper;
        public static bool useNumeric;
        public static bool useSpecial;

        /// <summary>
        /// Static function to generate the password.
        /// </summary>
        /// <param name="length"> Length of characters want in password </param>
        /// <returns></returns>
        public static string Generate(int length = 16)
        {
            string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeric = "0123456789";
            string special = "!'@#^$+½%&{/[(])}=\\?|_-*:";

            Random random = new Random();
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                if (useLower)
                {
                    result.Append(lowerChars[random.Next(lowerChars.Length)]);
                }
                if (useUpper)
                {
                    result.Append(upperChars[random.Next(upperChars.Length)]);
                }
                if (useNumeric)
                {
                    result.Append(numeric[random.Next(numeric.Length)]);
                }
                if (useSpecial)
                {
                    result.Append(special[random.Next(special.Length)]);
                }
                if (!useLower && !useUpper && !useNumeric && !useSpecial)
                {
                    result.Append(lowerChars[random.Next(lowerChars.Length)]);
                    result.Append(upperChars[random.Next(upperChars.Length)]);
                    result.Append(numeric[random.Next(numeric.Length)]);
                    result.Append(special[random.Next(special.Length)]);
                }
            }
            return result.ToString().Substring(0, length);
            
        }
    }

    
}
