namespace HeroAssembler.Models
{
    public class Mission
    {
        public string CodeName { get; set; }

        public Description Details { get; set; }

        public int TeamStrength { get; set; }

        public Team Team { get; set; }

        public bool Completed { get; set; }
    }
}