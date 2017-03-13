using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Outils
{
    public static class OutilsString
    {

        ///<summary>
        /// Vérifie que la chaine ne contient que des lettres
        /// http://romagny13.over-blog.com/article-6056598.html
        ///</summary>
        ///<param name="chaine"></param>
        ///<returns></returns>
        public static bool IsLetter(string chaine)
        {
            bool bResult;
            char[] cWork;
            System.Collections.IEnumerator EnumeratorcWork;

            bResult = true;
            cWork = chaine.ToCharArray();
            EnumeratorcWork = cWork.GetEnumerator();

            while (EnumeratorcWork.MoveNext() == true)
            {
                if (Char.IsLetter((Char)EnumeratorcWork.Current) == false)
                {
                    bResult = false;
                }
            }

            return bResult;
        }

        ///<summary>
        /// Vérifie que la chaine ne contient que des chiffres
        /// http://romagny13.over-blog.com/article-6056598.html
        ///</summary>
        ///<param name="chaine"></param>
        ///<returns></returns>
        public static bool isDigit(string chaine)
        {
            bool bResult;
            char[] cWork;
            System.Collections.IEnumerator EnumeratorcWork;

            bResult = true;
            cWork = chaine.ToCharArray();
            EnumeratorcWork = cWork.GetEnumerator();

            while (EnumeratorcWork.MoveNext() == true)
            {
                if (Char.IsDigit((Char)EnumeratorcWork.Current) == false)
                {
                    bResult = false;
                }
            }

            return bResult;
        }

        /// <summary>
        /// Vérifie si une chaîne de caractère est null, vide
        /// ou ne contient que des espaces
        /// </summary>
        /// <param name="chaine"></param>
        public static bool VerifierChaineNull(string chaine)
        {
            bool bResult = false;

            if (string.IsNullOrEmpty(chaine) || string.IsNullOrWhiteSpace(chaine))
            {
                bResult = true;
            }

            return bResult;
        }

        public static bool IsValidEmail(string chaine)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(chaine))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                chaine = Regex.Replace(chaine, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(chaine,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static string DomainMapper(Match match)
        {
            bool invalid = false;

            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
