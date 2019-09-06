using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExample.Part3
{
    internal class LogService : IBowlingService
    {
        private IBowlingService decoratedService;

        internal LogService(IBowlingService service) => decoratedService = service;

        public bool DoWeRoll(DayOfWeek dayOfWeek)
        {
            Console.WriteLine($"Checking to see if we should roll on { Enum.GetName(typeof(DayOfWeek), dayOfWeek) }...");

            return decoratedService.DoWeRoll(dayOfWeek);
        }
    }
}
