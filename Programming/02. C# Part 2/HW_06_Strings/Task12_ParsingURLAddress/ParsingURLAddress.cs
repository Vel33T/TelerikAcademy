using System;

/* Write a program that parses an URL address given in the format:
 * and extracts from it the [protocol], [server]
 * and [resource] elements.
 */

class ParsingURLAddress
{
    static void Main()
    {
        string address = "https://probanking.procreditbank.bg/pdf/General_Security_Information_.pdf";

        //Getting protocol
        int index = address.IndexOf(':');
        Console.WriteLine("[protocol] = " + address.Substring(0, index));
        address = address.Replace(address.Substring(0, index + 3), String.Empty);

        //Getting server
        index = address.IndexOf('/');
        Console.WriteLine("[server] = " + address.Substring(0, index));
        address = address.Replace(address.Substring(0, index), String.Empty);

        //Getting resource
        Console.WriteLine("[resource] = " + address);        
    }
}
