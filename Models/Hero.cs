namespace HeroAssembler.Models
{
    public class Hero
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}