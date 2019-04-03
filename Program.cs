/* 
 * Demonstrate a violation of the Liskov Substitution Principle
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new Pizza();
            DeepDish myDeepDish = new DeepDish();

            myPizza.AddTopping("Mushroom");
            myDeepDish.AddTopping("Pineapple");

            myPizza.PrintToppings();
            myDeepDish.PrintToppings();

            ProcessPizza(myPizza);   // This works.
            ProcessPizza(myDeepDish);   // This doesn't work.

        }
        /// <summary>
        /// Print the toppings on the Pizza
        /// </summary>
        /// <param name="pizza">The Pizza object to be processed</param>
        static void ProcessPizza(Pizza pizza)
        {
            // Debug statement. 
            Console.WriteLine("Program.ProcessPizza(): the Pizza object is a " + pizza.GetType());
            // If pizza is of type DeepDish then the PrintToppings method will come from the DeepDish class
            // and that method uses a different toppings collection.
            pizza.PrintToppings();  // Set a break point here.
        }
    }
}
