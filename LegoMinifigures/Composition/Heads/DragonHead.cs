using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Heads
{
    class DragonHead
    {
        public int NumOfTeeth { get; set; }
        public bool Spiked { get; set; }
        public LegoColor Color { get; set; }
        public BreathType BreathType { get; set; }

        public void Talk()
        {
            Console.WriteLine($"Stay away from my treasure.");
        }

        public void Breathe()
        {
            Console.WriteLine($"Dragon head attacks with {BreathType} breath.");
        }
    }
    enum BreathType
    {
        Stanky,
        Fire,
        Poison,
        Ice
    }
}
