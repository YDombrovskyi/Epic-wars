namespace EpicWars
{
    public class Human : Hero
    {
      
        public double Critical { get; set; } = 0;
        public Human(string name = "Human",double critical = 0)
        {
            Name = name;

            Critical = critical;
        }
    }
}
