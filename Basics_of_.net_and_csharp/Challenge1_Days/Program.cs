using System;

namespace Challange1
{
    public class Challange
    {
        static void Main(string[] args)
        {
            do {
                Console.Write("Please Enter The date: (Enter 'exit' to terminate): ");
                string? inpt = Console.ReadLine();
                DateTime dt = DateTime.Now;
                DateTime parsedd;
                if(inpt == "exit" || inpt == "Exit")
                {
                    break;
                }

                if (DateTime.TryParse(inpt, out parsedd))
                {
                    if (dt.Date == parsedd.Date)
                    {
                        Console.WriteLine("Today");
                    }
                    else if(dt > parsedd)
                    {
                        Console.WriteLine($"The Day's elsaped since last date is {(dt - parsedd).Days}");
                    }
                    else
                    {
                        Console.WriteLine($"The time remaining is {(parsedd - dt).Days}");
                    }
                }
                else
                {
                    Console.WriteLine("Not in the correct format");
                }

            }while(true);
        }
    }
}
