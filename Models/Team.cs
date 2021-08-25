using System.Collections.Generic;

namespace HeroAssembler.Models
{
    public class Team
    {
        public string Name { get; set; }
        public List<Hero> Members { get; set; }
    }
}