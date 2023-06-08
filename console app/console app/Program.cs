namespace console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>() {"uil", "kraai", "hond", "papegaii" };
            List<string> birds2 = new List<string>() {"meeuw", "duif" };
            birds.AddRange(birds2);
            birds.Remove("hond");

            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}