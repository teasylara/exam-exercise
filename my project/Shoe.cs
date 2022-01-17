using System;
using System.Collections.Generic;
using System.Text;

namespace my_project
{
    internal class Shoe
    {
        private int _id;
        private string _name;
        private double _price;
        private string _brand;

        public Shoe(int ID, string Name, double Price, string Brand)
        {
            _id = ID;
            _name = Name;
            _price = Price;
            _brand = Brand;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public override string ToString()
        {
            return $"Shoe information:\n ID: {_id}\n Shoe name: {_name}\n Shoe price: {_price}\n Shoe brand: {_brand}";
        }

    }
}


