using System;
using System.Collections.Generic;
using HeroAssembler.Models;

namespace HeroAssembler
{
    public class Alliance
    {
        public string Name { get; set; }

        private List<Hero> _heroes { get; set; }

        private List<Team> _teams { get; set; }

        public Alliance()
        {
            Name = "Unnamed Alliance";
            _heroes = new List<Hero>();
        }

        public Alliance(string name)
        {
            Name = name;
            _heroes = new List<Hero>();
        }

        public Alliance(string name, List<Hero> heroes)
        {
            Name = name;
            _heroes = heroes;
        }


        //write a method that Adds a Hero to the Alliance's heroes
        public void AddaHero(Hero hero)
        {
            _heroes.Add(hero);
        }


        //write a method that lists all of the alliances heroes
        public void ListAllHeroes()
        {
            Console.WriteLine($"All Heroes in Alliance {Name}");
            foreach (Hero hero in _heroes)
            {
                Console.WriteLine(hero.Name);
            }
        }

        public void Assemble()
        {
            Console.WriteLine($"{Name} Assemble!");
        }

    }
}