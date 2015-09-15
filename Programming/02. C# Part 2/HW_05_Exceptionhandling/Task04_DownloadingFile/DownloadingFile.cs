using System;
using System.Net;

/* Write a program that downloads a file from Internet
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and
 * stores it the current directory. Find in Google how to
 * download files in C#. Be sure to catch all exceptions
 * and to free any used resources in the finally block.
 */

class DownloadingFile
{
    static void Main()
    {
        using (WebClient download = new WebClient())
        {
            try
            {
                download.DownloadFile("asa", "../../downloaded-logo.jpg");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
