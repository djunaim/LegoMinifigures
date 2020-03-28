using LegoMinifigures.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Legs
{
    class BabyLegs : IColorful, IMoveable
    {
        public bool CanWalk { get; set; }
        public int NumOfRolls { get; set; }
        public bool IsClumsy => true;
        public bool HasPants { get; set; }
        public LegoColor Color => LegoColor.White;

        public void Walk(int steps)
        {
            if (CanWalk)
            {
                Console.WriteLine($"Baby legs walk around {steps} steps and then topple over.");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} baby feet.");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kick with the power of {NumOfRolls} fat rolls!!");
        }

        public void Move(int howFar)
        {
            Walk(howFar);
        }
    }
}
