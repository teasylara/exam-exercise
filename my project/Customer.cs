using System;
using System.Collections.Generic;
using System.Text;

namespace my_project
{
    internal class Customer
    {
        private string _name;
        private string _phoneNumber;

        public Customer (string Name, string PhoneNumber)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public override string ToString()
        {
            return $"\n Customer name: {Name} \n Customer number: {PhoneNumber}";
        }
    }
}
