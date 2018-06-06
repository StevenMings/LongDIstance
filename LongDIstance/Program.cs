using System;

//#TODO The start time will be entered as a floating point number(decimal) in the form HH.MM.
//#TODO Must not accept times that are greater than 23.59 (note that 6.69 is less than 23.59 but is an invalid time)
//#TODO Must not accept time whose last two digits are greater than 59.

//#DONE prompts the user for the starting time 
//#DONE prompts the user for the number of minutes of the call
//#DONE display the charges
//#DONE charges are based on the start time of the call
//#DONE use the correct rate for the time range it falls into 
//#DONE Validate that the number of minutes of the phone call is not negative


namespace LongDistanceCalls
{
    class Program

    {


        public static void Main(string[] args)
        {
            //Time Constants
            const double timeAStart = 0.00;
            const double timeAEnd = 06.59;
            const double timeBStart = 07.00;
            const double timeBEnd = 12.59;
            const double timeCStart = 13.00;
            const double timeCEnd = 19.00;
            const double timeDStart = 19.01;
            const double timeDEnd = 23.59;

            //Rate Constants
            const double rateA = 0.12;
            const double rateB = 0.23;
            const double rateC = 0.55;
            const double rateD = 0.35;


            // Input for call
            Console.Write("Hello, what was the start time of your call? ");
            var startTime = Console.ReadLine();
            var startTimeDbl = Convert.ToDouble(startTime);

            //Negative Check for call
            var callnegative = NegativeCheck(startTimeDbl, timeAStart);

            //Minutes Input
            Console.Write("How many minutes were you on the call? ");
            var minutes = Console.ReadLine();
            var minutesDbl = Convert.ToDouble(minutes);

            //Negative Check for minutes
            var minnegative = NegativeCheck(minutesDbl, timeAStart);

            //Rate Check && Post
            if (startTimeDbl > timeAStart && startTimeDbl < timeAEnd)
            {
                var rate = minutesDbl * rateA;
                Console.WriteLine("Your current rate is: " + rate);
            }
            else if (startTimeDbl > timeBStart && startTimeDbl < timeBEnd)
            {
                var rate = minutesDbl * rateB;
                Console.WriteLine("Your current rate is: " + rate);
            }
            else if (startTimeDbl > timeCStart && startTimeDbl < timeCEnd)
            {
                var rate = minutesDbl * rateC;
                Console.WriteLine("Your current rate is: " + rate);
            }
            else if (startTimeDbl > timeDStart && startTimeDbl < timeDEnd)
            {
                var rate = minutesDbl * rateD;
                Console.WriteLine("Your current rate is: " + rate);
            }

        }
        //Negative class
        public static double NegativeCheck(double a, double b)
        {
            if (a < b)
            {
                Console.WriteLine("Please do not use negative numbers.");
            }
            return a;

        }

    }
}
