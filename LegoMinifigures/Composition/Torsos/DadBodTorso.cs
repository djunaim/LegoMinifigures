using LegoMinifigures.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    // classes can implement as many interfaces as they want
    class DadBodTorso : TorsoBase, IColorful, IMoveable
    {
        public bool IsHairy { get; set; }
        public override bool ChiseledAbs
        {
            get { return false; }
            set { }
        }
        //public LegoColor Color => LegoColor.Yellow;

        public void ChangeTemp(string weather)
        {
            if (weather == "cold")
            {
                Console.WriteLine("Dad bod turns down thermostat.");
            }
            else
            {
                Console.WriteLine("Dan bod turns up the thermostat.");
            }
        }

        // if want to make a string literal use @ symbol
        public override void Flex()
        {
            Console.WriteLine($"The dad bod flexes his {(IsHairy ? "hairy" : "smooth")} "
                                + $" beer belly while using his {HandType} "
                                + " hands to point at his flabby arms.");
        }

        public void Move(int howFar)
        {
            Console.WriteLine($"Dances in the grocery store for {howFar} long.");
        }
    }
}
