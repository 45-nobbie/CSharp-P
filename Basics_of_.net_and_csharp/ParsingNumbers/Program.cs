using System;

namespace NumbersAndDates
{
    class NumbersAndDates
    {
        static void Main(string[] args)
        {
            /*            string[] NumStrs = { "  1 ", " 1.45  ", "-100", "5e+04 " };

                        int testint;
                        float testfloat;
                        bool result;

                        // TODO: The Parse method attempts to parse a string to a number and
                        // throws an exception if the parse is unsuccessful
                        *//*foreach (string str in NumStrs)
                        {
                            try
                            {
                                testfloat= float.Parse(str);
                                Console.WriteLine($"Number is {testfloat}");
                                testint = int.Parse(str);
                                Console.WriteLine($"{testint}");
                            }
                            catch(FormatException e)
                            {
                                Console.WriteLine($"Exception occours!! string '{str}' cannot be parsed {e.Message}");
                            }

                        }*//*

                        // TODO: The TryParse method returns 'true' if the parse is successful
                        result = int.TryParse(NumStrs[1], out testint);
                        Console.WriteLine($"Result:{result}, Value={testint}");*/
            /* int[] quarters = { 1, 2, 3, 4 };
             int[] sales = { 100000, 150000, 200000, 225000 };
             double[] intlMixPct = { .386, .413, .421, .457 };
             int val1 = 1234;
             decimal val2 = 1234.5678m;

             // TODO: Specifying Numerical formatting
             // General format is {index[,alignment]:[format]}
             // Common types are N (Number), G (General), F (Fixed-point), 
             // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
             // C (Currency in local format)
             Console.WriteLine($"The val1 is {val1,-7:G}");

             // TODO: Add a number after the format to specify precision
             Console.WriteLine($"The val1 is {val2,-7:G3}");


             // TODO: Formatting with alignment and spacing
             Console.WriteLine("Sales by Quarter:");
             Console.WriteLine($"{quarters[0],10:G} {quarters[1],10:G} {quarters[2],10:G} {quarters[3],10:G}");
             Console.WriteLine($"{sales[0],10:G} {sales[1],10:G} {sales[2],10:G} {sales[3],10:G}");
             //Console.WriteLine("International Sales:");
             Console.WriteLine($"{intlMixPct[0],10:P} {intlMixPct[1],10:P} {intlMixPct[2],10:P} {intlMixPct[3],10:P}");*/
            // TODO: Use DateTime.Now property to get the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            // TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
            DateTime Today = DateTime.Today;
            Console.WriteLine(Today);
            // TODO: DateOnly and TimeOnly represent just dates and times
            DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Date:{dt}, Time:{tm}");

            // TODO: Dates have properties that can be inspected
            Console.WriteLine(Today.DayOfWeek);
            Console.WriteLine(Today.DayOfYear);

            // TODO: Dates also have methods to change their values
           now =  now.AddDays(5);
           now =   now.AddHours(9);
           now =  now.AddMonths(1);
            Console.WriteLine(now);

            // TODO: The TimeSpan class represents a duration of time
            DateTime AprilFools = new DateTime(now.Year, 4, 1);
            DateTime NewYears = new DateTime(now.Year, 1, 1);

            TimeSpan Interval = AprilFools - NewYears;

            Console.WriteLine(Interval);


            // TODO: Dates can be compared using regular operators

        }
    }
}