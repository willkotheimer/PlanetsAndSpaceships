using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> anotherPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(anotherPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 3);

            planetList.Remove("Pluto");

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            var spaceCraft = new Dictionary<string, List<string>>
            {
                {"Sputnick", new List<string> {"Pluto","Venus","Mars", "Neptune" } },
                {"Enterprise", new List<string>{"Mercury", "Saturn", "Uranus"} },
                {"Voyager", new List<string> {"Neptune", "Pluto","Mars", "Earth"}}
            };

            foreach( var planet in planetList)
            {
                var shipList = new List<string>();
                foreach(var (name, planets) in spaceCraft)
                {
                    
                    if(planets.Contains(planet))
                    {
                        shipList.Add(name);
                    }
                   
                }
                Console.WriteLine($"{planet}: {string.Join(", ", shipList)}");

            }
        }
    }
}
