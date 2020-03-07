using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class Astronaut
    {
        // public property. Below is using enum type within property
        public Location Location { get; set; }

        // expression bodied property. Below means ALWAYS suited up. No setter. Saying if Name == "Space Person", it is always suited up
        public bool SuitedUp => Name == "Space Person";

        // read only property and can only assign value once class is instantiated
        public string Name { get; }

        // Public property with private setter. can have set as private and be updated in a method
        public string Job { get; private set; }
        public string Age { get; set; }
        public int OxygenLevel { get; set; }
        
        // when class gets called, need to specify name and job to use instantiated class
        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }
        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties");
        }
        public void Promote()
        {
            Job = "Commander of Janitors";
        }
    }
}
