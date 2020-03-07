using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class Ghost
    {
        public bool Friendly { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public string HauntingLocation { get; private set; }
        public DateTime DeathDay { get; }

        public Ghost(string name, DateTime deathDay)
        {
            Name = name;
            DeathDay = deathDay;
        }

        public void Haunt(string hauntingLocation)
        {
            HauntingLocation = hauntingLocation;
            Console.WriteLine($"{Name} has moved into {HauntingLocation}");
        }

        public void Spook()
        {
            // can 1 line and just have return at the end of it. Don't need else statement since return ends the method
            if (string.IsNullOrEmpty(HauntingLocation)) // return
            {
                return; 
            }
            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");
        }
    }
}
