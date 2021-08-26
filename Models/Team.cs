using System.Collections.Generic;

namespace HeroAssembler.Models
{
    public class Team
    {
        public string Name { get; set; }
        public List<Hero> Members { get; set; }

        public int TeamSize
        {
            get
            {
                return Members.Count;
            }
        }
    }

}