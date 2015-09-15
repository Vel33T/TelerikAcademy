using System;
using System.Text;

/* Write a program that encodes and decodes a string
 * using given encryption key (cipher). The key consists
 * of a sequence of characters. The encoding/decoding
 * is done by performing XOR (exclusive or) operation
 * over the first letter of the string with the first of
 * the key, the second – with the second, etc. When the
 * last key character is reached, the next is the first.
 */

class EncodingAndDecoding
{
    static string EncriptionDecription(string text, string cipher)
    {
        int cipherLen = cipher.Length;
        var encriptedText = new StringBuilder(text.Length);

        for (int i = 0; i < text.Length; i += cipherLen)
        {
            for (int j = 0; j < cipherLen; j++)
            {
                if (i + j > text.Length - 1) //The program runs without this check but it seems better with it.
                {
                    break;
                }
                encriptedText.Append((char)(text[i + j] ^ cipher[j]));
            }
        }
        return encriptedText.ToString();
    }

    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string cipher = Console.ReadLine();
        string result = "";
        result = EncriptionDecription(text, cipher);
        Console.WriteLine(text);
        Console.WriteLine(result);
        result = EncriptionDecription(result, cipher);
        Console.WriteLine(result);
    }
}
