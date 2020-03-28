using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    interface IMoveable
    {
        // only definint return type, name, and parameters
        // define how it looks like to the world
        // favor smaller interfaces instead of huge, multipurpose interfaces
        void Move(int howFar);
    }
}
