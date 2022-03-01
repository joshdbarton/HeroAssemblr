using System;
using System.Collections.Generic;
using HeroAssembler.Models;

namespace HeroAssembler
{
    public class Alliance
    {
        public string Name { get; set; }
        public List<Hero> Heroes {get;set;}

        public Alliance()
        {
            Name = "Unnamed Alliance";
            Heroes = new List<Hero>();
        }

        public Alliance(string name)
        {
            Name = name;
            Heroes = new List<Hero>();
        }


        //write a method that Adds a Hero to the Alliance's heroes
        public void AddHero(Hero hero)
        {
            Heroes.Add(hero);
        }
        //write a method that lists all of the alliances heroes
        public void ListAllianceHeroes()
        {
            foreach(Hero hero in Heroes)
            {
                Console.WriteLine($"{hero.Name} is in Alliance {Name}");
            }
        }



        public void Assemble()
        {
            Console.WriteLine($"{Name} Assemble!");
        }

        public void Assemble(string verb)
        {

            Console.WriteLine($"{Name} {verb}!");
        }

    }
}