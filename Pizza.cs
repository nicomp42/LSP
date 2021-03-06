﻿/* 
 * Demonstrate a violation of the Liskov Substitution Principle
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */using System;
using System.Collections.Generic;

namespace LSP
{
    /// <summary>
    /// A Pizza. This will serve as our base class.
    /// </summary>
    class Pizza
    {
        private List<String> mPizzaToppings;
        public Pizza() { mPizzaToppings = new List<string>(); }
        public List<String> toppings
        {
            get { return mPizzaToppings; }
            set { mPizzaToppings = value; }
        }
        /// <summary>
        /// Print the toppings on the pizza
        /// </summary>
        public void PrintToppings()
        {
            foreach (String t in mPizzaToppings)
            {
                Console.WriteLine(t);
            }
        }
        /// <summary>
        /// Add a topping to the the pizza
        /// </summary>
        /// <param name="topping"></param>
        public void AddTopping(String topping)
        {
            mPizzaToppings.Add(topping);
        }
    }
}
