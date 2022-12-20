namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gamename = new List<string>();

            gamename.Add("Mine Craft");
            gamename.Add("Sims 4");
            gamename.Add("Final Fantasy");
            gamename.Add("FallOut");

            gamename.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
