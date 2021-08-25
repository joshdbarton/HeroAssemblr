using System;
using HeroAssembler.Models;

namespace HeroAssembler
{
    class Program
    {
        static void Main(string[] args)
        {
            // args is an array of strings passed from the console when the program starts
            foreach (string arg in args)
            {
                Console.Write($" {arg}");
            }

            // passing parameter to constructor
            Alliance<Hero> avengers = new Alliance<Hero>("Avengers");
            Console.WriteLine($"Named Alliance: {avengers.Name}");

            //call a methods on the class instance
            avengers.Assemble();

            //add a hero to the Avengers
            avengers.AddAHero(new Hero() { Name = "Hawkeye" });

            // a method to list all heroes
            avengers.ListAllHeroes();

            // using the object initializer 
            Alliance<Hero> namedWithInitializerAlliance = new Alliance<Hero>() { Name = "Justice League" };
            Console.WriteLine($"Initializer Alliance: {namedWithInitializerAlliance.Name}");

            //relying on the default name in the overload of the constructor with no params
            Alliance<Hero> unknownAlliance = new Alliance<Hero>();
            Console.WriteLine($"Unknown Alliance: {unknownAlliance.Name}");


        }
    }
}

