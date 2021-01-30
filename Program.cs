/*
 * Name:Amanda Hernandez
 * Date:1/30/2021
 * Description: Deliverabel 3-Methods: C# Console application that asks the user for their name and prints back "Hello 'Name.'"
 */
using System;

namespace Methods_ISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user what their name is for user input
            Console.WriteLine("What is your name?");
            //call method
            Name();
          
        }
        //method to display "Hello 'User name'!"
        private static string Name()
        {

            //declare variable name and read input name
            String input = Console.ReadLine();

            //Display message "Hello 'user name'!"
            Console.WriteLine("Hello" + " " + input + "!");

            return input;
        }

}
}
;