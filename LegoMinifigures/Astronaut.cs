using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;

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

        // can pass in anything that is a TorsoBase. Takes away specificity
        public TorsoBase Torso { get; set; }
        public AstroLegs Legs { get; set; }
        public ZoeHead Head { get; set; }

        // difference between inheritance (can only inherit of 1 thing at a time) and composition (broken down to little things and thus, can get access to multiple things)

        // when class gets called, need to specify name and job to use instantiated class.
        public Astronaut(string name, string job, 
                        ZoeHead head, TorsoBase torso, 
                        AstroLegs legs)
        {
            Name = name;
            Job = job;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        // astronaut made up of multiple things and can be split up into smaller pieces to doing specific things, i.e. legs are responsible to walk. Composition - take a big thing and be built on multiple things to do that job (break big task into small pieces)
        public void DoYourJob(int stepCount)
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties");
            Legs.Walk(stepCount);
            Head.EatPie("cherry");
            Torso.Flex();
            Legs.Walk(stepCount);
        }
        public void Promote()
        {
            Job = "Commander of Janitors";
        }
    }
}
