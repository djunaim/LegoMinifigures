using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Composition.Heads;

namespace LegoMinifigures
{
    // interface default is internal
    interface IColorful
    {
        // cannot define accessibility nor behavior
        // can only define signature or property something that IColorful has and can only define publicly accessible class
        // works like abstract methods
        // everything in interface is public
        // when interface gets implemented, it needs to have at least what has been defined below and just needs to exist
        LegoColor Color { get; }
    }
}
