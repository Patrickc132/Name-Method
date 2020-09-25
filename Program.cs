using System;
using System.Runtime.CompilerServices;

namespace name_method
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            Console.Write("Please enter your full name");
            Console.WriteLine("");
            //this instructs the user

            try
            {
                string input = Console.ReadLine();

                //this will run the method
                Name(input);
            }
            catch
            {
                //error catch
                Console.WriteLine("An error has occured try again");
                Console.WriteLine("Press any key to try again!");
                Console.ReadKey(true);
            }
            

            static void Name(string input)
            {
                //this method will output the users name

                Console.WriteLine("Hello " + input.ToString() + ".");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
                

            }                     
        }
    }
}
