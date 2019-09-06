using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample
{
    interface IBowlingService
    {
        bool DoWeRoll(DayOfWeek dayOfWeek);
    }
}
