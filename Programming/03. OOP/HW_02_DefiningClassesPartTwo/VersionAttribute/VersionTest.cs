using System;

[VersionAttribute("2.11")]
class VersionTest
{
    static void Main()
    {
        Type typeClass = typeof(VersionTest);
        object[] attributes = typeClass.GetCustomAttributes(false);

        foreach (VersionAttribute attribute in attributes)
        {
            Console.WriteLine("The version of this class is: " + attribute.Version);
        }
    }
}
