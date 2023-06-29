namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\tbarm\OneDrive\Documenten\ma\mbo3\flex\c# opdrachten\2023P4ProgCs2\FileDirOpdracht");

            string path = Path.GetTempFileName();
            var fi1 = new FileInfo(path);

            foreach (var fi in dir.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}