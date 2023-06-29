namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\tkuij\OneDrive - Mediacollege Amsterdam\MA\Jaar_1\periode 4\PROG\PROG4Csharp");
            DirectoryInfo[] directorys = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            foreach (DirectoryInfo directory in directorys)
            {
                Console.WriteLine(directory.FullName);
            }

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }
        }
    }
}