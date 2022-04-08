using System;

namespace Driving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your year of birth");
            int result = 2022 - Convert.ToInt32(Console.ReadLine());

            if(result < 18)
            {
                Console.WriteLine("You are too young to drive");
            }
            else if (result > 18)
            {
                Console.WriteLine("drive csrefully");
            }
            else
            {
                Console.WriteLine("Congratulations,you my apply for your");
            }
        }
    }
}
