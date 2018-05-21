using System;

namespace PersistantBugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Persist.Persistence(999);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
