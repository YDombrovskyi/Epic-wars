using System;

namespace EpicWars
{
    class Battle
    {
        public static void StartBattle(Human human1, Elf elf1)
        {
            while (true)
            {
                if (GetAttackResult(human1, elf1) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
                //if (GetAttackResult(elf1, human1) == "Game over")
                //{
                //    Console.WriteLine("Game over");
                //    break;
                //}


            }
        }

        public static string GetAttackResult(Human humanA, Elf elfB)

        {
            double HumAAttkAmt = humanA.Attack();
            double ElfBBlkAmt = elfB.Block();
            double dmg2ElfB = HumAAttkAmt - ElfBBlkAmt;

            if (dmg2ElfB > 0)
            {
                elfB.Health = elfB.Health - dmg2ElfB;
            }
            else dmg2ElfB = 0;
            Console.WriteLine("{0} Attacks {1} and deals {2} damage",
                humanA.Name,
                elfB.Name,
                dmg2ElfB);

            Console.WriteLine("{0} Has {1} Health \n",elfB.Name,humanA.Health);
            if (elfB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is winnner",
                    elfB.Name,
                    humanA.Name);
                return "Game over";
            }
            else return "Fight again !";
        }
    }
}
