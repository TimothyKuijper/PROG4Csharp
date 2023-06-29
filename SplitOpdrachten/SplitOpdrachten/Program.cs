using System.Runtime.CompilerServices;

namespace SplitOpdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] content;
            content = File.ReadAllLines(@"C:\Users\tkuij\OneDrive - Mediacollege Amsterdam\MA\Jaar_1\periode 4\PROG\PROG4Csharp\SplitOpdrachten\SplitOpdrachten\stringsplit.txt");
            foreach (string line in content) 
            {
                string[] keyvalue = line.Split(':');
                string[] cijfersPerVak = keyvalue[1].Split(",");

                foreach (string split in keyvalue)
                {
                    Console.WriteLine(split);
                }
                foreach (string cijfers in cijfersPerVak)
                {
                    Console.Write(cijfers);
                }
            }
        }
    }
}