using System;
using System.Collections.Generic;
using HeroAssembler.Models;

namespace HeroAssembler
{
    public class Alliance
    {
        public string Name { get; set; }

        public Alliance()
        {
            Name = "Unnamed Alliance";
        }

        public Alliance(string name)
        {
            Name = name;
        }


        //write a method that Adds a Hero to the Alliance's heroes
        //write a method that lists all of the alliances heroes
        //write a method that creates a team, and adds the teams to the Alliance's teams
        //write a methods that deploys a team on a mission
        //write a method to list all active missions
        //write a method to complete a mission


        public void Assemble()
        {
            Console.WriteLine($"{Name} Assemble!");
        }

    }
}