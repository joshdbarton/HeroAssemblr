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




        public void Assemble()
        {
            Console.WriteLine($"{Name} Assemble!");
        }

    }
}