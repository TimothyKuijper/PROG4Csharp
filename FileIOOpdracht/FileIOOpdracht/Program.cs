using System.Runtime.InteropServices;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] content = File.ReadAllLines(@"leesdezefile.txt");
            for (var i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            string[] text = new string[] { "made", "with", "code!" };
            File.WriteAllLines(@"C:\Users\tkuij\OneDrive - Mediacollege Amsterdam\MA\Jaar_1\periode 4\PROG\PROG4Csharp\FileIOOpdracht\FileIOOpdracht\mijnnieuwetekst.txt", text);
            File.AppendAllText(@"C:\Users\tkuij\OneDrive - Mediacollege Amsterdam\MA\Jaar_1\periode 4\PROG\PROG4Csharp\FileIOOpdracht\FileIOOpdracht\mijnnieuwetekst.txt", "Gedaan!");
        }
    }
}