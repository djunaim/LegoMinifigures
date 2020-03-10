using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Heads
{
    class ZoeHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }

        // below is enum. OPtions for color
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }
        public void Talk()
        {
            Console.WriteLine($"Zoe astronaut says 'Tell my wife I love her very much.' while {FacialExpression} emphatically.");
        }
        public void EatPie(string typeOfPie)
        {
            if (typeOfPie == "apple")
            {
                Console.WriteLine("MMM...pie");
            }
            else
            {
                Console.WriteLine("This is awkward.");
            }
        }
    }

    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        ORange
    }
}
