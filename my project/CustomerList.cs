using System;
using System.Collections.Generic;
using System.Text;

namespace my_project
{
    internal class CustomerList
    {
        private List<Customer> _listOfCustomers = new List<Customer>();
        private ShoeMenu _shoeMenu;
        

        public CustomerList()
        {
            CustomerListSetup();
        }

        public ShoeMenu MenuChoicePath
        {
            set { _shoeMenu = value; }
        }

        public List<Customer> ListOfCustomers
        { 
            get { return _listOfCustomers; } 
        }

        public void CustomerListSetup()
        {
            Customer c1 = new Customer("Tea", "52726102");
            _listOfCustomers.Add(c1);

            Customer c2 = new Customer("Luka", "72839471");
            _listOfCustomers.Add(c2);

            Customer c3 = new Customer("Damir", "83729485");
            _listOfCustomers.Add(c3);

            Customer c4 = new Customer("Karlo", "16253749");
            _listOfCustomers.Add(c4);
        }

        public void CustomerMenuSelection()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("\n This is the customer menu selection:");
                Console.WriteLine("1. Show customers");
                Console.WriteLine("-----------------------------------");

                Console.Write("What do you want to do? \n");
                int.TryParse(Console.ReadLine(), out int userChoice);

                if (userChoice == 1)
                {
                    IzlistajCustomers();
                }
               
                else
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                }
            }

            void IzlistajCustomers()
            {
                foreach (var c in _listOfCustomers)
                {
                    Console.Write("\n" + c);
                }
            }
        }

       
    }
}
