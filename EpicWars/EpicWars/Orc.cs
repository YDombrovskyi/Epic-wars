namespace EpicWars
{
    public class Orc : Hero
    {
      
        public double Power { get; set; } = 0;

        public Orc(string name = "Orc", double power = 0)
        {
            Name = name;

            Power = power;
        }
    }
}
