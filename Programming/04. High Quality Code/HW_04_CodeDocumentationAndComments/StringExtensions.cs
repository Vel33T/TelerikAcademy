//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------
namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains string extension methods <see cref="System.String"/> class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Calculate Hash of the string
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The hash of the string.</returns>
        /// <seealso cref="http://en.wikipedia.org/wiki/Md5"/>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Checks if the input string contains some predefined values/words that
        /// can be interpreted as boolean True.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>True if the input string contains any of the predefined values/words.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Tries to parse the input string to <see cref="System.Int16"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The string value as <see cref="System.Int16"/> or 0 if TryParse == false.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Tries to parse the input string to <see cref="System.Int32"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The string value as <see cref="System.Int32"/> or 0 if TryParse == false.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Tries to parse the input string to <see cref="System.Int64"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The string value as <see cref="System.Int64"/> or 0 if TryParse == false.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Tries to parse the input string to <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The string value as <see cref="System.DateTime"/> or 0 if TryParse == false.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Converts first letter of a string to Uppercase.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The input string with capitalized first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns string positioned in <paramref name="input"/> from start position <paramref name="startFrom"/> 
        /// and between the occurrences of <paramref name="startString"/> and <paramref name="endString"/>.
        /// </summary>
        /// <param name="input">String to search into.</param>
        /// <param name="startString">Starting string.</param>
        /// <param name="endString">Ending string.</param>
        /// <param name="startFrom">Start position of the search.</param>
        /// <returns>Found string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        ///  Converts letters in a given string from cyrillic to latin.
        /// </summary>
        /// <param name="input">Cyrillic string.</param>
        /// <returns>Latin string.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
            {
                "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к",
                "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х",
                "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
            };

            var latinRepresentationsOfBulgarianLetters = new[]
            {
                "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
            };

            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        ///  Converts letters in a given string from latin to cyrillic.
        /// </summary>
        /// <param name="input">Latin string.</param>
        /// <returns>Cyrillic string.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
                "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
                "w", "x", "y", "z"
            };

            var bulgarianRepresentationOfLatinKeyboard = new[]
            {
                "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                "в", "ь", "ъ", "з"
            };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts string from cyrillic to latin and removes all 
        /// non-alphanumerical characters except period "." so that
        /// it is in a valid username format.
        /// </summary>
        /// <param name="input">Username string to process.</param>
        /// <returns>Processed username string.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts string from cyrillic to latin and removes all 
        /// non-alphanumerical characters except period "." also replaces 
        /// empty spaces " " with dashes "-" so that
        /// it is in a valid format for a file name. 
        /// </summary>
        /// <param name="input">File name string to process.</param>
        /// <returns>Processed file name string.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns substring from the beginning with
        /// length Math.Min(string's length, <paramref name="charsCount"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="charsCount">Number of characters.</param>
        /// <returns>Substring of the input.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Splits a string containing a filename and returns the file extension.
        /// </summary>
        /// <param name="fileName">Filename string.</param>
        /// <returns>String containing only the extension.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the corresponding content type for a specified file
        /// extension using dictionary.
        /// </summary>
        /// <param name="fileExtension">File extension string.</param>
        /// <returns>Content type.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtentionToContentType = new Dictionary<string, string>
            { 
                { "jpg", "image/jpeg" },
                { "jpeg", "image/jpeg" },
                { "png", "image/x-png" },
                { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
                { "doc", "application/msword" },
                { "pdf", "application/pdf" },
                { "txt", "text/plain" },
                { "rtf", "application/rtf" }
            };

            if (fileExtentionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtentionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string (sequence of characters) to a sequence of bytes.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Byte array.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
