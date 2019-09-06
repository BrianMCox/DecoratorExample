using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DecoratorExample
{
    internal class TimedService : IBowlingService
    {
        IBowlingService decoratedService;

        public TimedService(IBowlingService service) => decoratedService = service;

        public bool DoWeRoll(DayOfWeek dayOfWeek)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = decoratedService.DoWeRoll(dayOfWeek);
            sw.Stop();
            Console.WriteLine($"DoWeRoll execution took {sw.ElapsedMilliseconds} ms");

            return result;
        }
    }
}
