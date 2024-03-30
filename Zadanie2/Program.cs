namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppContext  db = new AppContext())
            {
                var fios = db.fios.ToList();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Список людей");
                Console.ResetColor();
                foreach (var f in fios)
                {
                    Console.WriteLine($"{f.Id} {f.FirstName} {f.LastName} {f.Age}");
                }
            }
        }
    }
}