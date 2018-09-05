using System;

namespace EpicWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rudy = new Human();
            var Gimly = new Elf();
            Battle.StartBattle(Rudy, Gimly);
            Console.Read();
        }
    }
}
