﻿using System;
using HeroAssembler.Models;

namespace HeroAssembler
{
    class Program
    {
        static void Main(string[] args)
        {

            // passing parameter to constructor
            Alliance avengers = new Alliance("Avengers");
            Console.WriteLine($"Named Alliance: {avengers.Name}");

            //call a method on the class instance
            avengers.Assemble();

            // using the object initializer 
            Alliance namedWithInitializerAlliance = new Alliance() { Name = "Justice League" };
            Console.WriteLine($"Initializer Alliance: {namedWithInitializerAlliance.Name}");

            //relying on the default name in the overload of the constructor with no params
            Alliance unknownAlliance = new Alliance();
            Console.WriteLine($"Unknown Alliance: {unknownAlliance.Name}");


        }
    }
}

