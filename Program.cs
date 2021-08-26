using System;
using HeroAssembler.Models;
using System.Collections.Generic;

namespace HeroAssembler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region examples

            Hero tonyStark = new Hero();
            tonyStark.Name = "Iron Man";
            tonyStark.SuperPower = "smart";
            tonyStark.DoubleAgent = true;

            Hero hawkeye = new Hero();
            hawkeye.Name = "Hawkeye";
            hawkeye.SuperPower = "good archer";
            hawkeye.DoubleAgent = false;
            // passing parameter to constructor

            Alliance avengers = new Alliance("Avengers");
            Alliance unnamedAlliance = new Alliance();

            Alliance tonyAndHawkeye = new Alliance("Tony and Hawkeye", new List<Hero>() { tonyStark, hawkeye });
            tonyAndHawkeye.ListAllHeroes();
            Console.WriteLine($"Named Alliance: {avengers.Name}");




            //call a method on the class instance
            avengers.Assemble();
            avengers.AddaHero(tonyStark);
            avengers.AddaHero(hawkeye);
            avengers.ListAllHeroes();

            #endregion
        }
    }
}

