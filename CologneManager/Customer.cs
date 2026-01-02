using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CologneManager
{
    public class Customer
    {
        // Fields (Private storage)
        private int _id;
        private string _name = "";
        private string _email = "";
        private string _phone = "";

        // Constructor
        public Customer(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email; // This triggers the check below
            Phone = phone;
        }

        // Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                // Made it require specific values to register it as an email
                if (!value.Contains("@"))
                {
                    throw new Exception("Invalid email format (must contain @)");
                }
                _email = value;
            }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}