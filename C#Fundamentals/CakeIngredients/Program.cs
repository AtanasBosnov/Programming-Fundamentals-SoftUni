using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the system. For every given ingredient, you should write: “Adding ingredient {name of the ingredient}.”. When you receive the command “Bake!” from the console you should stop the program and write “Preparing cake with {number of given ingredients} ingredients.”. 
             */

            string input = Console.ReadLine();
            int counter = 0;
            while (input != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
               
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients");
        }
    }
}
