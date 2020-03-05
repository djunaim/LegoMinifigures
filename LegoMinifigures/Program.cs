using System;

namespace LegoMinifigures
{
    class BodyParts
    {
        public bool HasHair { get; set; }
        public bool HasHat { get; set; }
        public bool HasHumanHead { get; set; }
        public bool HasLongTorso { get; set; }
        public bool HasTwoLegs { get; set; }
        public bool HasAccessories { get; set; }

        public void Jump()
        {
            if (HasTwoLegs)
            {
                Console.WriteLine("Use those legs");
            }
            else
            {
                Console.WriteLine("You're going to need more help");
            }
        }

        public void Attack()
        {
            if (HasLongTorso)
            {
                Console.WriteLine("That's a long reach");
            }
            else
            {
                Console.WriteLine("Going to need to work harder.");
            }
        }

        public void SpecialAttack()
        {
            if (HasHair && HasAccessories && HasLongTorso)
            {
                Console.WriteLine("Congrats, you've unlocked a special move");
            }
            else
            {
                Console.WriteLine("Going to need to up your game");
            }
        }

        public void NewChar()
        {
            if (HasHumanHead == false && HasHair == false && HasAccessories)
            {
                Console.WriteLine("You've unlocked Piccolo");
            }
            else
            {
                Console.WriteLine("Missed out on a DBZ character");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var character = new BodyParts();
            character.HasAccessories = true;
            character.HasHat = false;
            character.HasHair = true;
            character.HasHumanHead = false;
            character.HasLongTorso = true;
            character.HasTwoLegs = true;

            character.Jump();
            character.SpecialAttack();
            character.NewChar();

            Console.ReadLine();
        }
    }
}
