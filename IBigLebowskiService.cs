using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample
{
    internal interface IBigLebowskiService
    {
        bool DoWeRoll(DayOfWeek dayOfWeek);

        bool ShouldFWith(BigLebowskiCharacter character);
    }
}
