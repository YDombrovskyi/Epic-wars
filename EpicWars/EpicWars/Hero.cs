using System;

namespace EpicWars
{
    public class Hero

    {
        public string Name { get; set; } = "Hero";
        public double Health { get; set; } = 100;
        public double Damage { get; set; } = 100;
        public double Defence { get; set; } = 50;

        Random rnd = new Random();

        public double Attack()
        {
            return rnd.Next(1, (int)Damage);
        }
        public double Block()
        {
            return rnd.Next(1, (int)Defence);
        }
        
    }
}