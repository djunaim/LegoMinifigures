using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    // the : is similar to "extends" in React. The : creates "IS A" relationship
    class AstroTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }

        public override bool ChiseledAbs { get; set; }

        // override means method that looks like this in TorsoBase should have the instructions below
        public override void Flex()
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs!");
            }
            else if (HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show!");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok");
            }
        }

        // override below means it is overriding previously defined behavior
        public override void Breathe()
        {
            Console.WriteLine("Exhale, inhale...");
        }
    }
}
