using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    // enum have name and values that are options. Enum are actually integers under the covers. Enum is numbered like an array, but not an array. It's a collection of options. Can also set position value of location, i.e. Earth = 1. Can set it as 1 first so there is no default value when nothing has been set yet. Implicitly internal
    enum Location
    {
        Earth,
        Space,
        SpaceStation
    }
}
