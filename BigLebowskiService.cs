using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DecoratorExample
{
    #region Part 2
    //internal class BigLebowskiService : IBowlingService
    #endregion

    internal class BigLebowskiService : IBigLebowskiService
    {
        public bool DoWeRoll(DayOfWeek dayOfWeek)
        {
            // simulate a poor performing service by sleeping for a random interval
            var random = new Random();
            Thread.Sleep(random.Next(1000, 2000));

            // if it's Shabbos, Walter doesn't roll
            return dayOfWeek != DayOfWeek.Saturday;
        }

        public bool ShouldFWith(BigLebowskiCharacter character)
        {
            return character != BigLebowskiCharacter.JesusQuintana;
        }
    }
}
