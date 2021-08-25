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



        public void Assemble()
        {
            Console.WriteLine("Avengers Assemble!");
        }

    }
}