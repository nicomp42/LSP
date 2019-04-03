/* 
 * Demonstrate a violation of the Liskov Substitution Principle
 * Bill Nicholson
 * 
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;

namespace LSP
{
    /// <summary>
    /// A Deep Dish pizza. This will serve as our derived class.
    /// </summary>
    class DeepDish: Pizza
    {
        private HashSet<String> mDeepDishToppings;
        public DeepDish() { mDeepDishToppings = new HashSet<string>();}

        // 'new' keyword hides the toppings variable in the base class.
        public new HashSet<String> toppings
        {
            get { return mDeepDishToppings; }
            set { mDeepDishToppings = value; }
        }
        public new void AddTopping(String topping)
        {
            mDeepDishToppings.Add(topping);
        }
        public new void PrintToppings()
        {
            foreach (String t in mDeepDishToppings)
            {
                Console.WriteLine(t);
            }
        }

    }
}
