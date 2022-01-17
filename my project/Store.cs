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

            menu.ShoeMenuSelection();
        }
    }
}
