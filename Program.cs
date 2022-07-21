using System;

namespace MyOwnClass_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human eve = new Human("Eve", "Polastri", "brown", 1);

            Human vilanelle = new Human("Oksana", "Astankova", "green", 29);

            eve.IntroduceMyself();
            vilanelle.IntroduceMyself();
            Console.Read();
        }
    }
}
