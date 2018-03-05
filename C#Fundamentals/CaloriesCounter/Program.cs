using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You have to write a program, which counts the calories, which can be found in your pizza recipe. In your recipe, there are only four ingredients – cheese, tomato sauce, salami and pepper. Each ingredient contains a fixed amount of calories: 
                •	Cheese – 500 calories
                •	Tomato sauce – 150 calories
                •	Salami – 600 calories
                •	Pepper – 50 calories 
                If you receive one of these ingredients more than once, you should add the calories to the total amount again. You should not process any other ingredients. Ingredients are case-insensitive.
             */

            int numberOfIngredients = int.Parse(Console.ReadLine());
            
            int totalCalories = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "cheese")
                {
                    totalCalories += 500;
                }
                else if(input == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (input == "salami")
                {
                    totalCalories += 600;
                }
                else if (input == "pepper")
                {
                    totalCalories += 50;
                }else
                {
                    totalCalories += 0;
                }
                
            }
            Console.WriteLine($"Total calories: {totalCalories}");

        }
    }
}
