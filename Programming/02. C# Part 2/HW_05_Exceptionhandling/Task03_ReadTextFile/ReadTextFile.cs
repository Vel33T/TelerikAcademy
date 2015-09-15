using System;
using System.IO;
using System.Security;

/* Write a program that enters file name along with its
 * full file path (e.g. C:\WINDOWS\win.ini), reads its
 * contents and prints it on the console. Find in MSDN
 * how to use System.IO.File.ReadAllText(…). Be sure
 * to catch all possible exceptions and print user-
 * friendly error messages.
 */

class ReadTextFile
{
    static void Main()
    {
        try
        {
            string text = File.ReadAllText(@"C:\Windows\RtlExUpd.dll");
            Console.WriteLine(text);
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("The path is 'null'.");
        }
        catch (PathTooLongException)
        {
            Console.Error.WriteLine("The path, the file name or both are too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("The specified path is invalid.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.Error.WriteLine("The opperation is not supported or the caller doesn't have permission.");
        }
        catch (FileLoadException)
        {
            Console.Error.WriteLine("File not found.");
        }
        catch (NotSupportedException)
        {
            Console.Error.WriteLine("The path format is not supported.");
        }
        catch (SecurityException)
        {
            Console.Error.WriteLine("The caller does not have the required permission.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Error occured while opening the file.");
        }
    }
}
