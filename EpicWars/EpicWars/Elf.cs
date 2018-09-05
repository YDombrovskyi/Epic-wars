namespace EpicWars
{
    public class Elf : Hero
    {
       

        public double Evasion { get; set; } = 0;
        public Elf(string name = "Elf", double evasion = 0)
        {
            Name = name;

            Evasion = evasion;
        }
    }
}
