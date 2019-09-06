using DecoratorExample.Part3;
using System;

namespace DecoratorExample
{
    class Program
    {
        static bool keepChecking = true;
        static IBigLebowskiService service = new BigLebowskiService();

        #region Part 2
        //static IBowlingService service = new BigLebowskiService();
        #endregion

        static void Main(string[] args)
        {
            while (keepChecking)
            {
                PrintMainMenu();
                RunSelectedOption(Console.ReadLine());
                Console.WriteLine("Would you like to try again? (y/n)");
                keepChecking = Console.ReadLine().ToUpper() == "Y";
            }
        }

        static void RunSelectedOption(string userInput)
        {
            if (userInput == "1")
            {
                CheckIt();
                //CheckIt2();
                //CheckIt3();
            }
            else
            {
                SelectCharacter();
            }
        }

        static void CheckIt()
        {
            var result = service.DoWeRoll(GetRandomDay());
            WriteResult(result);
        }

        #region Part 2
        //static void CheckIt2()
        //{
        //    var timedService = new TimedService((IBowlingService) service);
        //    var result = timedService.DoWeRoll(GetRandomDay());
        //    WriteResult(result);
        //}
        #endregion

        #region Part 3
        //static void CheckIt3()
        //{
        //    var wrappedService = new LogService(new TimedService((IBowlingService) service));
        //    var result = wrappedService.DoWeRoll(GetRandomDay());
        //    WriteResult(result);
        //}
        #endregion

        static DayOfWeek GetRandomDay()
        {
            var random = new Random();
            return (DayOfWeek)random.Next(0, 7);
        }

        static void PrintMainMenu()
        {
            Console.WriteLine("1 - Check if we should roll");
            Console.WriteLine("2 - Check if we should F with");
        }

        static void SelectCharacter()
        {
            int selectedCharacter;
            var validEntry = false;
            Console.WriteLine("1 - The Dude");
            Console.WriteLine("2 - Walter Sobchak");
            Console.WriteLine("3 - Donny Kerabatsos");
            Console.WriteLine("4 - Jackie Treehorn");
            Console.WriteLine("5 - Bunny Lebowski");
            Console.WriteLine("6 - Maude Lebowski");
            Console.WriteLine("7 - Karl Hungus");
            Console.WriteLine("8 - Jesus Quintana");
            Console.WriteLine("9 - Smokey");
            Console.WriteLine("10 - The Stranger");

            validEntry = int.TryParse(Console.ReadLine(), out selectedCharacter);
            while (validEntry == false)
            {
                Console.WriteLine("Unrecognized entry, please enter a number");
                validEntry = int.TryParse(Console.ReadLine(), out selectedCharacter);
            }

            Console.WriteLine(service.ShouldFWith((BigLebowskiCharacter)selectedCharacter));
        }

        static void WriteResult(bool result)
        {
            Console.WriteLine
            (
                result ? "Yes, we should roll" :
                "It's Shabbos, no rolling"
            );
        }
    }
}
