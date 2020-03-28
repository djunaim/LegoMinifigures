using LegoMinifigures.Composition.Heads;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    // abstract will not allow the class to be instantiated. It modifies the class keyword, not an access modifier
    // can only be inherited one time, can define base level behvaior and choose to leave behavior off
    // inheritance allows ability to define method as abstract
    abstract class TorsoBase : IColorful
    {
        public abstract bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }
        public LegoColor Color => LegoColor.Yellow;

        // defining anything that has TorsoBase needs to have Flex method, but no instructions on what the method is. Any class that inherits from TorsoBase will have method Flex and has to provide info on how it gets implemented
        public abstract void Flex();

        // virtual - anything that inherits from me can change how the Breathe method works. Can be overriden. If don't want to change it, can get access of the method and will just have to call it
        public virtual void Breathe()
        {
            Console.WriteLine("Inhale, exhale...");
        }
    }
}
