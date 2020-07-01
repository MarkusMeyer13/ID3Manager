using System;

namespace ID3Cmd
{
    /// <summary>
    /// https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/delegates/using-delegates
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            ID3Reader id3Reader = new ID3Reader();
            id3Reader.Read();
            Console.ReadLine();
        }
    }
}
