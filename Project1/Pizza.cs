using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Pizza
    {
        private string size;
        private int toppingCheese;
        private int toppingPep;
        private int toppingHam;

        public Pizza(string size, int toppingCheese, int toppingPep, int toppingHam)
        {
            this.size = size;
            this.toppingCheese = toppingCheese;
            this.toppingHam = toppingHam;
            this.toppingPep = toppingPep;
        }

        public string getSize()
        {
            return this.size;
        }

        public int getToppingCheese()
        {
            return this.toppingCheese;
        }

        public int getToppingPep()
        {
            return this.toppingPep;
        }

        public int getToppingHam()
        {
            return this.toppingHam;
        }

        public void setSize(string size)
        {
            this.size = size;
        }

        public void setToppingCheese(int toppingCheese)
        {
            this.toppingCheese = toppingCheese;
        }

        public void setToppingPep(int toppingPep)
        {
            this.toppingPep = toppingPep;
        }

        public void setToppingHam(int toppingHam)
        {
            this.toppingHam = toppingHam;
        }

        public double CalculateCost()
        {
            double cost = 0.0;
            if (this.size == "small")
            {
                cost += 10;
            }
            else if (this.size == "medium")
            {
                cost += 12;
            }
            else if (this.size == "large")
            {
                cost += 14;
            }
            else
            {
                cost = 0;
            }
            return (cost + (toppingPep * 2) + (toppingHam * 2) + (toppingCheese * 2));
        }

        public string ToString()
        {
            return ("The " + size + " Pizza with " +
                toppingCheese + " cheese toppings, " +
                toppingHam + " ham toppings and " +
                toppingPep + " pepperoni toppings costs $" +
                CalculateCost());
        }
    }
}
    