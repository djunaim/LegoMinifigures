using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Legs
{
    class AstroLegs
    {
        public bool HasPants { get; set; }
        public ShoeType Shoes { get; set; }

        // creating random generator field
        Random _rng = new Random(4);
        public void Walk(int steps)
        {
            Console.WriteLine($"The astronaut legs moonwalked {steps} steps.");
        }

        // below method is returning something
        public int Jump()
        {
            var heightOfJump = _rng.Next();
            return heightOfJump;
        }
    }

    enum ShoeType
    {
        None,
        Boots,
        FlipFlops
    }
}
