using System;

namespace Chap1;

class Chapter1
{
    static void Main(string[] args)
    {
  /*      Console.Write("Please Enter Your name: ");
        string? str = Console.ReadLine();
        if (str != null)
        {
            Console.WriteLine($"Hello from {str}");
        }
        else
        {
            Console.WriteLine("Please give a value");
        }*/
        OperatingSystem os = Environment.OSVersion;
        Console.WriteLine(os.Platform);
        Console.WriteLine(os.VersionString);
    }
}