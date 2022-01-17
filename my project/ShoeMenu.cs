using System;
using System.Collections.Generic;
using System.Text;

namespace my_project
{
    internal class ShoeMenu
    {
        private List<Shoe> _shoeCatalog = new List<Shoe>();
        private CustomerList _customerList;

        public CustomerList CustomerList
        {
            set { _customerList = value; }
        }

        public ShoeMenu()
        {
            ShoeListSetup();
        }

        public List<Shoe> ShoeCatalog 
        { 
            get { return _shoeCatalog; } 
        }

       void ShoeListSetup()
        {
            Shoe shoe1 = new Shoe(1, "Superstar", 780, "Adidas");
            _shoeCatalog.Add(shoe1);

            Shoe shoe2 = new Shoe(2, "Special", 760, "Adidas");
            _shoeCatalog.Add(shoe2);

            Shoe shoe3 = new Shoe(3, "Creepers", 1270, "Puma");
            _shoeCatalog.Add(shoe3);

            Shoe shoe4 = new Shoe(4, "Boots", 1780, "Dr. Martens");
            _shoeCatalog.Add(shoe4);
        }

        public void ShoeMenuSelection()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\n This is the shoe menu selection:");
                Console.WriteLine("1. Show shoe menu");
                Console.WriteLine("2. Delete a shoe");
                Console.WriteLine("3. Open customer menu");
                Console.WriteLine("-----------------------------------");

                Console.Write("What do you want to do? \n");
                int.TryParse(Console.ReadLine(), out int userChoice);

                if (userChoice == 1)
                {
                    ShoeSelection();
                }

                if (userChoice == 2)
                {
                    DeleteShoe();
                }

                if (userChoice == 3)
                {
                    _customerList.CustomerMenuSelection();
                }

                else
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                }
            }
            
        }

        public void ShoeSelection()
        {
            foreach (var shoe in _shoeCatalog)
            {
                Console.WriteLine("\n" + shoe);
            }
        }

        void DeleteShoe()
        {
            ShoeSelection();

            Console.WriteLine("Deleting a shoe");

            while (true)
            {
                string shoeID;
                Shoe obj;
                Console.Write("Enter ID of the shoe you want to delete: ");
                
                shoeID = Console.ReadLine();

                obj = FindShoe(shoeID);

                if (obj != null)
                {
                    Console.WriteLine("Deleting shoe with id " + shoeID);
                    _shoeCatalog.Remove(obj);
                    break;
                }

                else
                {
                    Console.WriteLine("This shoe could not be found.Please try again");
                }
            } 
        }

        Shoe FindShoe(string shoeID) //Not the same as SearchPizza method
        {
            Shoe shoe = _shoeCatalog.Find(x => x.ID.ToString() == shoeID);
            return shoe;
        }
    }
}
