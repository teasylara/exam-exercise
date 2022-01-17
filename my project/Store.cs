using System;
using System.Collections.Generic;
using System.Text;

namespace my_project
{
    internal class Store
    {
        public static void Start()
        {
            ShoeMenu menu = new ShoeMenu();

            //Ovdje si trebala napraviti instancu objekta cutomer list jer nije postojala (tu isto moze nastati null refernece)
            CustomerList customers = new CustomerList();

            //Ovo je vazan dio
            //Tu si trebala postaviti poveznciu izmedu dvije instance klase u programu
            //Ovdje govoris da customer vraijabla u klasi ShoeMenu da je taj customer menu zapravo ovaj customers koji si napravila u 14. redu
            //Odnosno govoris customers meniju kada pozoves "menu" da se to odnsoi na shoe menu koji si napravila u 11. redu
            //Inace kada bi pozvala iz jedne kalse drugu ne bi pokazivala na nista konkretno pa bi dobila gresku
            menu.CustomerList = customers;
            customers.MenuChoicePath = menu;

            menu.ShoeMenuSelection();
        }
    }
}
