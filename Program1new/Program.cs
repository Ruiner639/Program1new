using System;

namespace Program1new
{
    class Program
    {
        static void Main(string[] args)
        {
            //I slightly modified the program :)
            try
            {
                Console.WriteLine("Enter how old are you");
                int years = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("In 10 years you will be " + (years + 10));
            }
            catch
            {
                Console.WriteLine("You entered an invalid value");
            }
        }
    }
}
