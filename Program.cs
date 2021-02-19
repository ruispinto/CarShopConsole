using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Nissan","Micra",9500);
            Car d = new Car("Ford", "Mustang", 90500);

            Console.WriteLine();
            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            Console.WriteLine();
            int action = chooseAction();
            while (action != 0)
            {
                Console.WriteLine("You chose " + action);
                action = chooseAction();

            }
            
            Console.WriteLine("Car c is as follows:");
            Console.WriteLine("Make: " + c.Make + ", Model: " + c.Model + ", Price: " + c.Price + " Eur");

            Console.WriteLine();
            Console.WriteLine("Car d is as follows:");
            Console.WriteLine("Make: " + d.Make + ", Model: " + d.Model + ", Price: " + d.Price + " Eur");

            Store s = new Store();

            s.ShoppingList.Add(c);
            s.ShoppingList.Add(d);

            decimal total = s.CheckOut();

            Console.WriteLine();
            Console.WriteLine("Store value is " + total + " Eur");

            Console.ReadLine();
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
